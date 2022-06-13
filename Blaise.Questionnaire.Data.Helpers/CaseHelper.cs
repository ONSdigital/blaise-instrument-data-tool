using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;
using Newtonsoft.Json;
using CaseModel = Blaise.Questionnaire.Data.Helpers.Models.CaseModel;

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
            int primaryKey, string caseSampleFile)
        {
            var sampleData = GetSampleDataFields(caseSampleFile);
            _blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);
            for (var count = 0; count < expectedNumberOfCases; count++)
            {
                try
                {
                    var caseModel = new CaseModel(primaryKey, sampleData);
                    CreateCaseInBlaise(caseModel, questionnaireName, serverParkName);
                    primaryKey++;
                    Console.WriteLine($"Created case '{primaryKey}' for questionnaire '{questionnaireName}'");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"There was an error {ex} writing case '{primaryKey}' for questionnaire '{questionnaireName}'");
                    Thread.Sleep(2000);
                }
            }

            Console.WriteLine($"Completed cases for questionnaire '{questionnaireName}'");
        }

        public void CreateCaseInBlaise(CaseModel caseModel, string questionnaireName, string serverParkName)
        {

            _blaiseCaseApi.CreateCase(caseModel.PrimaryKey, caseModel.DataFields, questionnaireName, serverParkName);
        }

        private Dictionary<string, string> GetSampleDataFields(string caseSampleFile)
        {
            if (string.IsNullOrWhiteSpace(caseSampleFile))
            {
                return new Dictionary<string, string>();
            }

            var sampleDataFile = Path.Combine(Environment.CurrentDirectory, caseSampleFile);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(sampleDataFile));
        }
    }
}
