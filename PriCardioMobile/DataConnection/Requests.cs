using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Newtonsoft.Json;

namespace PriCardioMobile.DataConnection
{
    class Requests
    {
        static ServerConnection connection = new ServerConnection();
        static ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        public static async Task<string> Login(string login, string password)
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("login", login));
            data.Add(new KeyValuePair<string, string>("pass", password));
            string res = await connection.PostAsync("home/login", data);
            return res;
        }

        public static async Task<Models.Customer> GetData()
        {
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            data.Add(new KeyValuePair<string, string>("login", localSettings.Values["id"].ToString()));
            string res = await connection.PostAsync("", data);
            var customer = JsonConvert.DeserializeObject<Models.Customer>(res);
            //customer.Name = "Ivan";
            //customer.Pulse = 65;
            //customer.SYS = 145;
            //customer.DIA = 82;
            return customer;
        }
    }
}
