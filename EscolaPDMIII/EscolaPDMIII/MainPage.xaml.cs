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
            Core.JsonDecode json = new Core.JsonDecode();

            json.jsonalunos("http://tomasfernandes.pt/Rest/example/alunos");
            json.jsondisciplinas("http://tomasfernandes.pt/Rest/example/disciplinas");
            json.jsonexames("http://tomasfernandes.pt/Rest/example/exames");
            json.jsonhorarios("http://tomasfernandes.pt/Rest/example/horarios");
            json.jsonprofessores("http://tomasfernandes.pt/Rest/example/professores");
            json.jsonpropinas("http://tomasfernandes.pt/Rest/example/propinas");

            login("work@tomasfernandes.pt", "Pass");



        }


        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage2());
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

            }
            else if(result == "Login Errado")
            {
                //LOGIN ERRADO
            }else if(result == "ROOT")
            {
                //ADMIM
            }
            else
            {

            }
        }
    }
}
