using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Questionnaire.Data.Helpers.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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

        public void CreateCasesInBlaise(int numberOfCases, string questionnaireName, string serverParkName, 
            int primaryKey)
        {
            var caseModels = new List<CaseModel>();
            try
            {
                for (var count = 1; count <= numberOfCases; count++)
                {
                    var caseDataModel = new CaseDataModel(primaryKey);
                    caseModels.Add(caseDataModel.ToCaseModel());
                    primaryKey++;

                    if (MaxChunkSizeOrMaxCountReached(count, numberOfCases))
                    {
                        _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
                        caseModels = new List<CaseModel>();
                        Console.WriteLine($"Total cases written {count}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex} writing {caseModels.Count} cases for questionnaire '{questionnaireName}'");
            }

            Console.WriteLine($"Completed creating cases for questionnaire '{questionnaireName}'");
        }

        public void CreateCasesInBlaise(string questionnaireName, string serverParkName, string caseSampleFile)
        {
            _blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);

            var caseModels = new List<CaseModel>();
            var sampleCaseList = GetSampleDataFields(caseSampleFile);
            var count = 1;

            try
            {
                foreach (var sampleCase in sampleCaseList)   
                {
                    var primaryKey = int.Parse(sampleCase["qiD.Serial_Number"]);
                    var caseDataModel = new CaseDataModel(primaryKey, sampleCase);
                    caseModels.Add(caseDataModel.ToCaseModel());

                    if (MaxChunkSizeOrMaxCountReached(count, sampleCaseList.Count))
                    {
                        _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
                        caseModels = new List<CaseModel>();
                        Console.WriteLine($"Total cases written {count}");
                    }

                    count++;
                }

                _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex} writing {caseModels.Count} cases for questionnaire '{questionnaireName}'");
            }

            Console.WriteLine($"Completed creating cases for questionnaire '{questionnaireName}'");
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

        private static bool MaxChunkSizeOrMaxCountReached(int count, int maxCount)
        {
            const int maxChunkSize = 500;
            return count % maxChunkSize == 0 || count == maxCount;
        }
    }
}
