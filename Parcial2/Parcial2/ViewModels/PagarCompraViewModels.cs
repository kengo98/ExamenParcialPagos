namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System;

    public class PagarCompraViewModels : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private bool isRefreshing;
        private String idCompra;
        #endregion

        #region Properties

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructor
        public PagarCompraViewModels(string idCom)
        {
            this.idCompra = idCom;
            this.apiService = new ApiService();
            this.Pagar();
        }
        #endregion

        #region Methods
        private async void Pagar()
        {
            var lista = await this.apiService.PUT<Pagos>(
                 "https://pagarcompra.azurewebsites.net/",
                 "api/",
                 "PagarCompra/" + this.idCompra
                );
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(
                     Pagar);
            }
        }

        public ICommand newCommand
        {
            get
            {
                return new RelayCommand(
                     Pagar);
            }
        }
        #endregion
    }
}