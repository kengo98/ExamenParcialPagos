using Parcial2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Parcial2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class obtenerDatosView : ContentPage
    {
        public obtenerDatosView()
        {
            InitializeComponent();
            BindingContext = new ObtenerDatosIotViewModel();
        }
    }
}