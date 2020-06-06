namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System.Threading.Tasks;
    using System;

    class PendienteDePagoViewModels : BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<Pagos> listPendientePagos;
        private bool isRefreshing = false;
        const int RefreshDuration = 2;
        #endregion

        #region Properties
        public ObservableCollection<Pagos> ListPendientePagos
        {
            get { return this.listPendientePagos; }
            set { SetValue(ref this.listPendientePagos, value); }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructor
        public PendienteDePagoViewModels()
        {
            this.apiService = new ApiService();
            this.LoadPagos();
        }
        #endregion

        #region Methods
        private async void LoadPagos()
        {
            var lista = await this.apiService.Get<Pagos>(
                 "https://consultarpendientedepagos.azurewebsites.net/",
                 "api/",
                 "Consultar/1"
                );
            this.ListPendientePagos = new ObservableCollection<Pagos>(
                lista);

        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {

                RelayCommand a =  new RelayCommand(
                    LoadPagos);
                this.isRefreshing = false;
                return a;
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

        async Task RefreshItemsAsync()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(RefreshDuration));
            LoadPagos();
            IsRefreshing = false;
        }

    }


}

