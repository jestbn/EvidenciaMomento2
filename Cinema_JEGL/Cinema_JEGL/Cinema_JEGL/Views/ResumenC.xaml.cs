using Cinema_JEGL.Models;
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
	public partial class ResumenC : ContentPage
	{
		public ResumenC (Pelicula peli, Funcione funci)
		{
			InitializeComponent ();
            BindingContext = peli;
            BindingContext = funci;
		}

        private void Button_Pressed(object sender, EventArgs e)
        {

        }
    }
}