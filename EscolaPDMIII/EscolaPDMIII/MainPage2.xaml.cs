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
	public partial class MainPage2 : ContentPage
	{
		public MainPage2 ()
		{
			InitializeComponent ();
		}
        

        async void ConsultarHorarios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarHorarios());
        }

        async void ConsultarUltimasNotas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarNotas());
        }

        async void ConsultarCurriculoAcademico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarHorarios());
        }

        async void ConsultarPropinas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConsultarPropinas());
        }

        async void ConsultarCalendario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarioExames());
        }
    }
}