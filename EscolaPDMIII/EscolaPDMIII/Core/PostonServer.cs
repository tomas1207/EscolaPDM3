using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace EscolaPDMIII.Core
{
    class PostonServer
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly HttpWebResponse webResponse;

        public async Task<string> PostData(string username, string password, string role, string extensonLink)
        {
            string url = extensonLink;
            var dados = new Dictionary<string, string>
            {
                {"email",username },
                {"pass",password },
                {"role",role }
            };
            var content = new FormUrlEncodedContent(dados);
            var response = await client.PostAsync("http://www.tomasfernandes.pt/Rest/example/" + url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;

        }
        public async Task<string> PostLogin(string username, string password, string extensonLink)
        {
            string url = extensonLink;
            var dados = new Dictionary<string, string>
            {
                {"email",username },
                {"pass",password }
            };
            var content = new FormUrlEncodedContent(dados);
            var response = await client.PostAsync("http://www.tomasfernandes.pt/Rest/example/" + url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            

            return responseString;
            
                

        }


    }
}
