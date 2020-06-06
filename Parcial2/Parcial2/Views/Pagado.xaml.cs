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
    public partial class Pagado : ContentPage
    {
        public Pagado()
        {
            InitializeComponent();
           BindingContext = new PagosViewModel();
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pagos K = e.CurrentSelection.FirstOrDefault() as Pagos;
            for (int i = 0; i<K.productos.Length; i++)
            {
                DisplayAlert("Alert", K.productos[i], "OK");
            }
            
        }
    }
}