using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace EscolaPDMIII.Core
{
    class PostonServer
    {
        private static readonly HttpClient client = new HttpClient();


        public async Task<string> PostData(string username, string password, string role, string extensonLink)
        {
            string url = extensonLink;
            var dados = new Dictionary<string, string>
            {
                {"email",username },
                {"password",password },
                {"role",role }
            };
            var content = new FormUrlEncodedContent(dados);
            var response = await client.PostAsync("http://www.tomasfernandes.pt/Rest/example/" + url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;

        }


    }
}
