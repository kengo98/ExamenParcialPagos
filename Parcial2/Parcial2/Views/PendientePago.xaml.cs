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
    public partial class PendientePago : ContentPage
    {
        public PendientePago()
        {
            InitializeComponent();
            BindingContext = new PendienteDePagoViewModels();
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pagos K = e.CurrentSelection.FirstOrDefault() as Pagos;

            Navigation.PushAsync(new OpcionPendienteDePago(K));
            Navigation.RemovePage(this);

        }
    }
}