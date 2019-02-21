using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace EscolaPDMIII
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
         

            InitializeComponent();
           // Core.JsonDecode json = new Core.JsonDecode();

           //Core.alunos alunos = json.jsonalunos("http://tomasfernandes.pt/Rest/example/alunos");
          
           
           
            
          }

        

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
           
        }
        async void login()
        {
            Core.PostonServer poston = new Core.PostonServer();
            Task<string> test = poston.PostData("Tomasfernandes@gmail.com", "ola", "ROOT", "loginpdm");
            var result = await test;
        }
    }
}
