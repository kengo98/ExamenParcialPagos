
namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System.Threading.Tasks;
    using System;

    class ObtenerDatosIotViewModel : BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<TempHum> listDatos;
        private bool isRefreshing = false;
        const int RefreshDuration = 2;
        #endregion

        #region Properties
        public ObservableCollection<TempHum> ListDatos
        {
            get { return this.listDatos; }
            set { SetValue(ref this.listDatos, value); }
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
        public ObtenerDatosIotViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPagos();
        }
        #endregion

        #region Methods
        private async void LoadPagos()
        {
            var lista = await this.apiService.Get<TempHum>(
                 "https://obtenerdatosiotkengo.azurewebsites.net/",
                 "api/",
                 "ObtenerDatos"
                );
            this.ListDatos = new ObservableCollection<TempHum>(
                lista);

        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                this.isRefreshing = true;
                RelayCommand a = new RelayCommand(
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
