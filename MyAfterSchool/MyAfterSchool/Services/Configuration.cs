using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MyAfterSchool.Services
{
    public class Configuration: ConfigurationSection
    {
       
        public static Configuration GetConfiguration()
        {
            Uri uri = HttpContext.Current.Request.Url;
            Configuration configuration =
                ConfigurationManager
                .GetSection("emailInfo")
                as Configuration;

            if (configuration != null)
            {
                return configuration;
            }

            return new Configuration();
        }

        [ConfigurationProperty("address", IsRequired = true)]
        public string Address
        {
            get { return this["address"].ToString(); }
        }

        [ConfigurationProperty("username", IsRequired = false)]
        public string Username
        {
            get { return this["username"].ToString(); }
        }

        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get { return this["password"].ToString(); }
        }

        [ConfigurationProperty("host", IsRequired = true)]
        public string Host
        {
            get
            {
                Uri uri = HttpContext.Current.Request.Url;
                String host = uri.Host.ToString();
                return host;
            }
           
    }

        [ConfigurationProperty("port", IsRequired = false, DefaultValue = 25)]
        public int Port
        {
            get
            {
                Uri uri = HttpContext.Current.Request.Url;
                
                string port = uri.Host;
                int result = 0;
                if (int.TryParse(port, out result))
                {
                    return result;
                }
                throw new Exception("Invalid port.");
            }
        }

        [ConfigurationProperty("sslEnabled", IsRequired = false, DefaultValue = false)]
        public bool IsSslEnabled
        {
            get
            {
                bool result = false;
                if (bool.TryParse(this["sslEnabled"].ToString(), out result))
                {
                    return result;
                }
                throw new Exception("Invalid ssl state.");
            }
        }
    }
}