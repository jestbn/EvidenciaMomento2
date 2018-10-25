using Cinema_JEGL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_JEGL.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Funciones : ContentPage
	{
		public Funciones (Pelicula peli)
		{
			InitializeComponent ();
            lblTitulo.Text = peli.Nombre;
            lblFecha.Text = "Date:" + DateTime.Now.ToString();



            var funcion = new Funcione();

            BindingContext = funcion;

        }

        private async Task ListaFuncion_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var funci = e.SelectedItem as Funcione;
            var pelicula = e.SelectedItem as Pelicula;
            await Navigation.PushAsync(new ResumenC(pelicula, funci));
        }
    }
}