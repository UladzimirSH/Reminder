using System;
using System.Configuration;

namespace Services {
    class ConfigService : IConfigService {
        private const int DEFAULT_UTC_RECIEVE_HOUR = 10;

        public string GetPhoneNumber() {
            return GetValueFromSettings("phoneNumber");
        }

        public int GetUtcRecieverHour() {
            string hour = GetValueFromSettings("utcRecieveHour");
            if (string.IsNullOrEmpty(hour)) {
                return DEFAULT_UTC_RECIEVE_HOUR;
            }
            return Int32.Parse(hour);
        }

        private string GetValueFromSettings(string key) {
            return ConfigurationSettings.AppSettings[key];
        }
    }
}
