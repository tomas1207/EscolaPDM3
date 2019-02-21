using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarNotas : ContentPage
	{
		public ConsultarNotas ()
		{
			InitializeComponent ();
            ObservableCollection<ConsultarNotas> listaNotas = new ObservableCollection<ConsultarNotas>();
		}
	}
}