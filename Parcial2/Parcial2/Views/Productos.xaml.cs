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
    public partial class Productos : ContentPage
    {
        public Productos()
        {
            InitializeComponent();
            BindingContext = new ProductosViewModel();
            Fecha.Text = "Fecha: "+DateTime.Now.ToString("dd/MM/yyyy");
        }
        async void btnComprarClicked(object sender, EventArgs args)
        {
            //para saber cuantos registros hay

            //primero creamos el pago
            String[] pro = new string[5] {"pechuga", "huevo","zanahoria","tomate","lechuga"};
            Pagos a = new Pagos()
            {
                id = "16",
                idCliente = "1",
                fecha = DateTime.Now.ToString("dd/MM/yyyy"),
                productos = pro,
                montoTotal = 57
            };
            InsertarPendienteDePagoViewModel insert = new InsertarPendienteDePagoViewModel(a);
            await DisplayAlert("Alert", "Se anadio a la lista de pendientes de pago", "OK");
            Thread.Sleep(50);
        }
    }
}