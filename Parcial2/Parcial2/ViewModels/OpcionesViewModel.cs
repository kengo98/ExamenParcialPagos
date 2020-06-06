using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Parcial2.ViewModels
{
    class OpcionesViewModel : BaseViewModel
    {
        public ObservableCollection<Pagos> detallePago { get; set; }
        public ObservableCollection<Productos> ListaProductos { get; set; }

        public OpcionesViewModel(Pagos x)
        {
            detallePago = new ObservableCollection<Pagos>
            {
                new Pagos
                {
                    id = x.id,
                    idCliente = x.idCliente,
                    productos = x.productos,
                    fecha = x.fecha,
                    montoTotal = x.montoTotal,
                    pagado = false
                }
            };
            ListaProductos = new ObservableCollection<Productos>{};

            for (int i = 0; i< x.productos.Length; i++)
            {
                ListaProductos.Add(new Productos() {nombre = x.productos[i], id = "", imagen = x.productos[i] + ".png", precio = 0.0 });
            }
        }


    }
}
