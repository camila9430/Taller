﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerXamarin.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ingreso : ContentPage
	{
		public Ingreso ()
		{
			InitializeComponent ();
		}

        private async void Ingreso_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Personas());
        }
    }
}