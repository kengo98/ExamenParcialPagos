namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    class InsertarPendienteDePagoViewModel : BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<Pagos> pendientePago;
        private bool isRefreshing;
        public Pagos content;
        #endregion

        #region Properties
        public ObservableCollection<Pagos> PendientePago
        {
            get { return this.pendientePago; }
            set { SetValue(ref this.pendientePago, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructor
        public InsertarPendienteDePagoViewModel(Pagos a)
        {
            this.content = a;
            this.apiService = new ApiService();
            this.LoadPagos();
        }
        #endregion

        #region Methods
        private async void LoadPagos()
        {
            await this.apiService.POST<Pagos>(
                 "https://insertarpendientedepagos.azurewebsites.net/",
                 "api/",
                 "InsertarPendientesDePago",
                 this.content
                );
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(
                    LoadPagos);
            }
        }

        public ICommand newCommand
        {
            get
            {
                return new RelayCommand(
                    LoadPagos);
            }
        }
        #endregion
    }


}