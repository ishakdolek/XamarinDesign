using HydMobileApp.Model;
using HydMobileApp.Page;
using HydMobileApp.View.Slider;
using Xamarin.Forms;

namespace HydMobileApp
{
    public class App : Application
    {
     
        public App()
        {
            MainPage = new NavigationPage(new HydMasterPage());
        }

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
    }
}
