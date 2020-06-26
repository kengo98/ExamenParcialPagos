using Parcial2.Models;
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
    public partial class EnviarMsjView : ContentPage
    {
        public EnviarMsjView()
        {
            InitializeComponent();
        }

        async void btnEnviarMensaje(object sender, EventArgs args)
        {
            Mensaje a = new Mensaje()
            {
                mensaje = txtMensaje.Text
            };
            EnviarMensajeViewModel mensaje = new EnviarMensajeViewModel(a);
            await DisplayAlert("Alert", "Mensaje enviado Correctamente", "OK");
        }

        async void btnMostrarUltimo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new obtenerDatosView());
            //Navigation.RemovePage(this);
        }

        
    }
}