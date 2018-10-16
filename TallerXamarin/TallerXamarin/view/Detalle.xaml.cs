using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerXamarin.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerXamarin.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalle : ContentPage
	{
		public Detalle (Usuario1 usuario)
		{
			InitializeComponent ();
		}
	}
}