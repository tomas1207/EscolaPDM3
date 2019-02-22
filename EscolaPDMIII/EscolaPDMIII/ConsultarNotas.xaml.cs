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
	public partial class ConsultarNotas : ContentPage
	{
        NotaView notaView;
        public ConsultarNotas ()
		{

			InitializeComponent();
            notaView = new NotaView();
            FindByName("listaNotas");
            listaNotas.ItemsSource = notaView.Notas;


        }
       
	}
}