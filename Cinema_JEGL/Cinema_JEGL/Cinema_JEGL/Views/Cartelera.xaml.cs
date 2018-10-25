using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cinema_JEGL.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_JEGL.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cartelera : ContentPage
	{
		public Cartelera ()
		{
			InitializeComponent ();
            CargarCartelera();
		}

        private async Task CargarCartelera()
        {
            HttpClient cliente = new HttpClient
            {
                BaseAddress = new Uri("https://misapis.azurewebsites.net/")
            };
            var request = await cliente.GetAsync("api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listCartelera = JsonConvert.DeserializeObject<List<Pelicula>>(responseJson);
                ListaCartelera.ItemsSource =  listCartelera;
            }
        }

        private async void ListaCartelera_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pelicula = e.SelectedItem as Pelicula;  
            await Navigation.PushAsync(new Funciones(pelicula));
        }
    }
}