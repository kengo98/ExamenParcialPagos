using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Parcial2.ViewModels
{
    class ProductosViewModel : BaseViewModel
    {
        public ObservableCollection<Productos> Products{ get; set;}
        
        public ProductosViewModel()
        {
            this.Products = new ObservableCollection<Productos> //Solo para elejemplo
            {
                new Productos
                {
                    id = "1",
                    nombre = "pechuga",
                    precio = 20,
                    imagen = "pechuga.png"
                },
                new Productos
                {
                    id = "2",
                    nombre = "huevo",
                    precio = 35,
                    imagen = "huevo.png"
                },
                new Productos
                {
                    id = "3",
                    nombre = "zanahoria",
                    precio = 5,
                    imagen = "zanahoria.png"
                },
                new Productos
                {
                    id = "4",
                    nombre = "tomate",
                    precio = 7,
                    imagen = "tomate.png"
                },
                new Productos
                {
                    id = "5",
                    nombre = "lechuga",
                    precio = 10,
                    imagen = "lechuga.png"
                },

            };
        }

    }
}
