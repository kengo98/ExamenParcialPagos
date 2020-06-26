namespace Parcial2.ViewModels
{
    using Parcial2.Helpers;
    using Parcial2.Models;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    class EnviarMensajeViewModel : BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private ObservableCollection<Mensaje> mensaje;
        private bool isRefreshing;
        public Mensaje content;
        #endregion

        #region Properties
        public ObservableCollection<Mensaje> Mensaje
        {
            get { return this.mensaje; }
            set { SetValue(ref this.mensaje, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructor
        public EnviarMensajeViewModel(Mensaje a)
        {
            this.content = a;
            this.apiService = new ApiService();
            this.LoadMensaje();
        }
        #endregion

        #region Methods
        private async void LoadMensaje()
        {
            await this.apiService.POST<Mensaje>(
                 "https://sendmessagekengoiot.azurewebsites.net/",
                 "api/",
                 "SendMessage",
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
                    LoadMensaje);
            }
        }

        public ICommand newCommand
        {
            get
            {
                return new RelayCommand(
                    LoadMensaje);
            }
        }
        #endregion
    }


}