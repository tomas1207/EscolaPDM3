using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage_Prof : ContentPage
	{
		public MainPage_Prof ()
		{
			InitializeComponent ();
		}


        async void MarcarExame_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MarcarExame());
        }

        async void ConsultarHorario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarHorarios()); //é precisso mudar para consultarhorario_prof
        }

        private void Calificar_Clicked(object sender, EventArgs e)
        {

        }
    }
}