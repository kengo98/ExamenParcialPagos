using Parcial2.Models;
using Parcial2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpcionPendienteDePago : ContentPage
    {
        private Pagos det;
        public OpcionPendienteDePago(Pagos detalles)
        {
            InitializeComponent();
            BindingContext = new OpcionesViewModel(detalles);
            Fecha.Text = "Fecha: " + detalles.fecha;
            monto.Text = "Monto Total: " + detalles.montoTotal + "Bs";
            this.det = detalles;
        }

        async void btnEliminarClicked(object sender, EventArgs args)
        {
            EliminarPendienteDePagoViewModel eliminar = new EliminarPendienteDePagoViewModel(det.id);
            Thread.Sleep(3000);
            await Navigation.PushAsync(new PendientePago());
            Navigation.RemovePage(this);
            await DisplayAlert("Alert", "Eliminado", "OK");
        }
        async void btnPagarClicked(object sender, EventArgs args)
        {
            //para pagar la compra vamos a usar un put
            PagarCompraViewModels pagar = new PagarCompraViewModels(det.id);
            await DisplayAlert("Alert", "Pagado", "OK");
            Thread.Sleep(3000);
            await Navigation.PushAsync(new PendientePago());
            Navigation.RemovePage(this);
        }
        async void btnSalirClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PendientePago());
            Navigation.RemovePage(this);
        }


    }
}