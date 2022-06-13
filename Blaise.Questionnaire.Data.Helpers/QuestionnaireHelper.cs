using System.Collections.Generic;
using System.Linq;
using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Enums;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;

namespace Blaise.Questionnaire.Data.Helpers
{
    public class QuestionnaireHelper
    {
        private readonly IBlaiseQuestionnaireApi _blaiseQuestionnaireApi;

        public QuestionnaireHelper(ConnectionModel connectionModel)
        {
            _blaiseQuestionnaireApi = new BlaiseQuestionnaireApi(connectionModel);
        }

        public static QuestionnaireHelper GetInstance(ConnectionModel connectionModel)
        {
            return new QuestionnaireHelper(connectionModel);
        }

        public IEnumerable<string> GetQuestionnaires()
        {
            var questionnaires = _blaiseQuestionnaireApi.GetQuestionnairesAcrossServerParks();

            return questionnaires.Select(i => i.Name);
        }

        public void InstallQuestionnaire(string questionnaireName, string serverPark, string questionnaireFile)
        {
            _blaiseQuestionnaireApi.InstallQuestionnaire(questionnaireName, serverPark, questionnaireFile, QuestionnaireInterviewType.Cati);
        }
    }
}
