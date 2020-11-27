using System;

namespace Common.Models
{
    public class ConfigurationModel : IConfigurationModel
    {
        public string DatabaseName { get; private set; }
        public int PullIntervalInSeconds { get; private set; }
        public string ApiAddress { get; private set; }
        public string ApiKey { get; private set; }
        public string ApiHost { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
