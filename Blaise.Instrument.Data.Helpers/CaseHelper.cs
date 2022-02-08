using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Blaise.Instrument.Data.Helpers.Models;
using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;
using Newtonsoft.Json;

namespace Blaise.Instrument.Data.Helpers
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

        public void CreateCasesInBlaise(int expectedNumberOfCases, string instrumentName, string serverParkName, 
            int primaryKey, string caseSampleFile)
        {
            var sampleData = GetSampleDataFields(caseSampleFile);
            _blaiseCaseApi.RemoveCases(instrumentName, serverParkName);
            for (var count = 0; count < expectedNumberOfCases; count++)
            {
                try
                {
                    var caseModel = new CaseModel(primaryKey, sampleData);
                    CreateCaseInBlaise(caseModel, instrumentName, serverParkName);
                    primaryKey++;
                    Console.WriteLine($"Created case '{primaryKey}' for instrument '{instrumentName}'");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"There was an error {ex} writing case '{primaryKey}' for instrument '{instrumentName}'");
                    Thread.Sleep(2000);
                }
            }

            Console.WriteLine($"Completed cases for instrument '{instrumentName}'");
        }

        public void CreateCaseInBlaise(CaseModel caseModel, string instrumentName, string serverParkName)
        {

            _blaiseCaseApi.CreateCase(caseModel.PrimaryKey, caseModel.DataFields, instrumentName, serverParkName);
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
