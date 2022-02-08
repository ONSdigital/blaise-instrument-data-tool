using System.Collections.Generic;
using System.Linq;
using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Enums;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;

namespace Blaise.Instrument.Data.Helpers
{
    public class InstrumentHelper
    {
        private readonly IBlaiseSurveyApi _blaiseSurveyApi;

        public InstrumentHelper(ConnectionModel connectionModel)
        {
            _blaiseSurveyApi = new BlaiseSurveyApi(connectionModel);
        }

        public static InstrumentHelper GetInstance(ConnectionModel connectionModel)
        {
            return new InstrumentHelper(connectionModel);
        }

        public IEnumerable<string> GetInstruments()
        {
            var instruments = _blaiseSurveyApi.GetSurveysAcrossServerParks();

            return instruments.Select(i => i.Name);
        }

        public void InstallInstrument(string instrumentName, string serverPark, string instrumentFile)
        {
            _blaiseSurveyApi.InstallSurvey(instrumentName, serverPark, instrumentFile, SurveyInterviewType.Cati);
        }
    }
}
