using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EscolaPDMIII.Models;
using EscolaPDMIII.MyDataSource;

using System.Collections;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarPropinas : ContentPage
	{
        PropinaView propinaView;
        public ConsultarPropinas ()
		{
			InitializeComponent ();
            propinaView = new PropinaView();
            FindByName("listaNotas");
            listaPropinas.ItemsSource = propinaView.Propinas;
        }
	}
}