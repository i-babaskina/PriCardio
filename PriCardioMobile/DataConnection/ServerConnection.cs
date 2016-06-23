﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PriCardioMobile.DataConnection
{
    class ServerConnection
    {
        const string serverUrl = "http://localhost:3336/";
        public async Task<string> PostAsync(string url, List<KeyValuePair<string, string>> postData)
        {
            try
            {
                var client = new HttpClient();
                var content = new FormUrlEncodedContent(postData);
                var response = await client.PostAsync(serverUrl + url, content);
                var responseText = await response.Content.ReadAsStringAsync();
                return responseText;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
