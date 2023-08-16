using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Questionnaire.Data.Helpers.Models;
using Newtonsoft.Json;

namespace Blaise.Questionnaire.Data.Helpers
{
    public class CaseHelper
    {
        private readonly IBlaiseCaseApi _blaiseCaseApi;

        public CaseHelper(ConnectionModel connectionModel)
        {
            _blaiseCaseApi = new BlaiseCaseApi(connectionModel);
        }

        public static CaseHelper GetInstance(ConnectionModel connectionModel)
        {
            return new CaseHelper(connectionModel);
        }

        public void CreateCasesInBlaise(int expectedNumberOfCases, string questionnaireName, string serverParkName, 
            int primaryKey)
        {
            //_blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);
            var caseModels = new List<CaseModel>();
            try
            {
                for (var count = 0; count < expectedNumberOfCases; count++)
                {
                    var caseDataModel = new CaseDataModel(primaryKey);
                    caseModels.Add(new CaseModel(caseDataModel.PrimaryKey, caseDataModel.DataFields));
                    primaryKey++;
                }

                _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex} writing {caseModels.Count} cases for questionnaire '{questionnaireName}'");
            }

            Console.WriteLine($"Completed creating cases for questionnaire '{questionnaireName}'");
        }

        public void CreateCasesInBlaise(string questionnaireName, string serverParkName, string caseSampleFile)
        {
            //_blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);

            var caseModels = new List<CaseModel>();
            var sampleCaseList = GetSampleDataFields(caseSampleFile);
            try
            {
                foreach (var sampleCase in sampleCaseList)
                {

                    var primaryKey = int.Parse(sampleCase["qiD.Serial_Number"]);
                    var caseDataModel = new CaseDataModel(primaryKey, sampleCase);
                    caseModels.Add(new CaseModel(caseDataModel.PrimaryKey, caseDataModel.DataFields));

                }

                _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex} writing {caseModels.Count} cases for questionnaire '{questionnaireName}'");
            }

            Console.WriteLine($"Completed creating cases for questionnaire '{questionnaireName}'");
        }

        public void CreateCaseInBlaise(CaseDataModel caseDataModel, string questionnaireName, string serverParkName)
        {

            _blaiseCaseApi.CreateCase(caseDataModel.PrimaryKey, caseDataModel.DataFields, questionnaireName, serverParkName);
        }

        private List<Dictionary<string, string>> GetSampleDataFields(string caseSampleFile)
        {
            if (string.IsNullOrWhiteSpace(caseSampleFile))
            {
                return new List<Dictionary<string, string>>();
            }

            var json = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(File.ReadAllText(caseSampleFile));
            return json;
        }
    }
}
