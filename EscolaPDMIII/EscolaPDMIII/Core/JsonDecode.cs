using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EscolaPDMIII.Core
{
    class JsonDecode
    {

        public void jsonalunos(string link)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(link);

                var result = JsonConvert.DeserializeObject<dynamic>(json);

                JObject joResponse = JObject.Parse(json);
             
                JArray array = (JArray)joResponse["Alunos"];
                int lenght = array.Count();
                for(int i = 0; i < lenght; i++)
                {
                    string statu = array[i]["id"].ToString();
                }
          

            }
        }
    }
}
