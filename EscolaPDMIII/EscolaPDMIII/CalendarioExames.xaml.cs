using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using EscolaPDMIII.MyDataSource;
using System.Collections;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarioExames : ContentPage
	{
        ExameView exameView;
		public CalendarioExames ()
		{
			InitializeComponent ();
            exameView = new ExameView();
            FindByName("listaExames");
            listaExames.ItemsSource = exameView.Exames;


         }   
             
        
	}
}