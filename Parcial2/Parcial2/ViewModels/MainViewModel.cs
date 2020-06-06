using Parcial2.Helpers;
using Parcial2.Models;
using System.Collections.ObjectModel;

namespace Parcial2.ViewModels
{
    public class MainViewModel
    {

        #region ViewModels
        private PagosViewModel Pagos;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Pagos = new PagosViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
