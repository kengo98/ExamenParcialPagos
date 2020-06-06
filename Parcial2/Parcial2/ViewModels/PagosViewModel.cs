namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using System.Threading.Tasks;

    public class PagosViewModel:BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<Pagos> listPagos;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<Pagos> ListPagos 
        {
            get { return this.listPagos; }
            set { SetValue(ref this.listPagos, value); }

        }

        public bool IsRefreshing
        {
            get => this.isRefreshing;
            set
            {
                this.isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        #endregion

        #region Constructor
        public PagosViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPagos();
        }
        #endregion

        #region Methods
        private async void LoadPagos()
        {
            this.isRefreshing = true;
            var lista = await this.apiService.Get<Pagos>(
                 "https://consultarpago.azurewebsites.net/",
                 "api/",
                 "ConsultarPago/1"
                );
            this.ListPagos = new ObservableCollection<Pagos>(
                lista);
            this.isRefreshing = false;
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
