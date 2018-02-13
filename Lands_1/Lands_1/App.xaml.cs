namespace Lands_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Xamarin.Forms;
    using views;
    public partial class App : Application
	{

        #region constructors
        public App ()
		{
			InitializeComponent();

            MainPage = new LoginPage();
		}
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
