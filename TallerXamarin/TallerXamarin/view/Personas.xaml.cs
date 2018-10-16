using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TallerXamarin.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerXamarin.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Personas : ContentPage
	{
		public Personas ()
		{
			InitializeComponent ();
            CargarUsuarios();
		}

        private void CargarUsuarios()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50599/Help/ResourceModel?modelName=Publicaciones");

            var request = client.GetAsync("/api/Publicaciones").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = responseJson.DeserializeObject<List<Publicacion>>(responseJson);
                ListUsuarios.ItemsSource = response;
            }
        }

        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)

        { 
            var usuario = e.SelectedItem as Usuario1;
            await Navigation.PushAsync(new Detalle(usuario));
        }
    }
}