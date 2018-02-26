
namespace Lands_1.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    
    using System.ComponentModel;
   
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel : BaseViewModel
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        #region Attributes
        
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region properties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                SetValue(ref this.password, value);
            }
        }
        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                SetValue(ref this.isRunning, value);
            }
        }

        public bool IsRemenbered
        {
            get;
            set;
        }

        public bool IsEnable
        {
            get
            {
                return this.isEnable;
            }
            set
            {
                SetValue(ref this.isEnable, value);
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemenbered = true;
            this.IsEnable = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }

        }



        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "ERROR",
                    "You must enter an Email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "ERROR",
                    "You must enter an Password",
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnable = false;

            if (this.Email != "jzuluaga55@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnable = true;
                await Application.Current.MainPage.DisplayAlert(
                   "ERROR",
                   "email or password incorrect",
                   "Accept");
                this.Password = string.Empty;

                return;
            }

            this.IsRunning = false;
            this.IsEnable = true;

            await Application.Current.MainPage.DisplayAlert(
                   "OK",
                   "OK",
                   "Accept");

        }

        #endregion

    }
}






