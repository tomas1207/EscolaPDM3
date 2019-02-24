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
            FindByName("managment");
            
            Core.JsonDecode json = new Core.JsonDecode();

            json.jsonalunos("http://tomasfernandes.pt/Rest/example/alunos");
            json.jsondisciplinas("http://tomasfernandes.pt/Rest/example/disciplinas");
            json.jsonexames("http://tomasfernandes.pt/Rest/example/exames");
            json.jsonhorarios("http://tomasfernandes.pt/Rest/example/horarios");
            json.jsonprofessores("http://tomasfernandes.pt/Rest/example/professores");
            json.jsonpropinas("http://tomasfernandes.pt/Rest/example/propinas");

           // login("work@tomasfernandes.pt", "Pass");



        }


        void OnLoginButtonClicked(object sender, EventArgs e)
        {
           login(usernameEntry.Text.ToString(), passwordEntry.Text.ToString());
        }
        async void addlogin()
        {
            Core.PostonServer poston = new Core.PostonServer();
            var test = poston.PostData("Tomasfernandes@gmail.com", "ola", "ROOT", "loginpdm");
            var result = await test;

        }
        async void login(string email, string pass)
        {
            Core.PostonServer poston = new Core.PostonServer();
            var login = poston.PostLogin(email, pass, "loginREST");
            var result = await login;
            if (result == "Aluno")
            {
                await Navigation.PushAsync(new MainPage2());
            }
            else if(result == "Login Errado")
            {
                //LOGIN ERRADO
            }else if(result == "ROOT")
            {
                await Navigation.PushAsync(new MainPage_Admin());
            }
            else
            {
                await Navigation.PushAsync(new MainPage_Prof());
            }
        }
    }
}
