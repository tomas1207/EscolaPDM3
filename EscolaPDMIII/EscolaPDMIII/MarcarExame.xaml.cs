﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscolaPDMIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MarcarExame : ContentPage
	{
		public MarcarExame ()
		{
			InitializeComponent ();
		}

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void OnMarcarExameButtonClicked(object sender, EventArgs e)
        {

        }
    }
}