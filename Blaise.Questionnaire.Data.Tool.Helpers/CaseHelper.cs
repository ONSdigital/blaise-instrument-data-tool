using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Questionnaire.Data.Tool.Helpers.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Blaise.Questionnaire.Data.Tool.Helpers
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

        public void CreateCasesInBlaise(int numberOfCases, string questionnaireName, string serverParkName, int primaryKey)
        {
            _blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);

            var caseModels = new List<CaseModel>();
            try
            {
                for (var count = 1; count <= numberOfCases; count++)
                {
                    var caseDataModel = new CaseDataModel(primaryKey);
                    caseModels.Add(caseDataModel.CaseModel());
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

        public void CreateCasesInBlaise(string questionnaireName, string serverParkName, string caseFile)
        {
            _blaiseCaseApi.RemoveCases(questionnaireName, serverParkName);

            var caseModels = new List<CaseModel>();
            var caseList = GetDataFields(caseFile);
            var count = 1;

            if (string.IsNullOrWhiteSpace(caseFile))
            {
                Console.WriteLine("No file provided. Using default data.");
            }
            else
            {
                Console.WriteLine($"Using data from file: {caseFile}");
                Console.WriteLine($"Loaded {caseList.Count} cases from file '{caseFile}'.");
            }

            try
            {
                foreach (var caseData in caseList)
                {
                    if (!caseData.ContainsKey("qiD.Serial_Number"))
                    {
                        Console.WriteLine($"Sample case missing 'qiD.Serial_Number': {JsonConvert.SerializeObject(caseData)}");
                        continue;
                    }

                    if (!int.TryParse(caseData["qiD.Serial_Number"], out var primaryKey))
                    {
                        Console.WriteLine($"Invalid 'qiD.Serial_Number': {caseData["qiD.Serial_Number"]}");
                        continue;
                    }

                    var caseDataModel = new CaseDataModel(primaryKey, caseData);
                    var caseModel = caseDataModel.CaseModel();

                    Console.WriteLine($"Creating case model: {JsonConvert.SerializeObject(caseModel)}");

                    caseModels.Add(caseModel);

                    if (MaxChunkSizeOrMaxCountReached(count, caseList.Count))
                    {
                        Console.WriteLine($"Writing {caseModels.Count} cases to Blaise.");
                        _blaiseCaseApi.CreateCases(caseModels, questionnaireName, serverParkName);
                        caseModels = new List<CaseModel>();
                        Console.WriteLine($"Total cases written {count}");
                    }

                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error {ex} writing {caseModels.Count} cases for questionnaire '{questionnaireName}'");
            }

            Console.WriteLine($"Completed creating cases for questionnaire '{questionnaireName}'");
        }

        private List<Dictionary<string, string>> GetDataFields(string caseFile)
        {
            if (string.IsNullOrWhiteSpace(caseFile))
            {
                return new List<Dictionary<string, string>>();
            }

            var json = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(File.ReadAllText(caseFile));
            return json;
        }

        private static bool MaxChunkSizeOrMaxCountReached(int count, int maxCount)
        {
            const int maxChunkSize = 500;
            return count % maxChunkSize == 0 || count == maxCount;
        }
    }
}
