using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EscolaPDMIII.Models;

using System.Collections;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultarNotas : ContentPage
	{
		public ConsultarNotas ()
		{

			InitializeComponent ();
            //BindingContext = new NotasViewModel ();
            ArrayList ListNotas = new ArrayList();
            ListNotas = Core.GlogalVar.notaexames;
             

    }
       
	}
}