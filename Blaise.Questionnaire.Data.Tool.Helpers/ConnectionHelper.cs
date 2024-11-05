using Blaise.Nuget.Api.Api;
using Blaise.Nuget.Api.Contracts.Interfaces;
using Blaise.Nuget.Api.Contracts.Models;

namespace Blaise.Questionnaire.Data.Tool.Helpers
{
    public class ConnectionHelper
    {
        private readonly IBlaiseHealthApi _blaiseHealthApi;

        public ConnectionHelper(ConnectionModel connectionModel)
        {
            _blaiseHealthApi = new BlaiseHealthApi(connectionModel);
        }

        public static ConnectionHelper GetInstance(ConnectionModel connectionModel)
        {
            return new ConnectionHelper(connectionModel);
        }

        public bool ConnectionSuccessful => ConnectionModelValid &&
                                            _blaiseHealthApi.ConnectionToBlaiseIsHealthy() &&
                                            _blaiseHealthApi.RemoteConnectionToBlaiseIsHealthy();

        public bool ConnectionModelValid => _blaiseHealthApi.ConnectionModelIsHealthy();
    }
}
