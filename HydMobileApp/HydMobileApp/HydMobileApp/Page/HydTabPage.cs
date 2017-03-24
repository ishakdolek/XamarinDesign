using HydMobileApp.View.HydTabPages;
using HydMobileApp.View.Slider;
using Xamarin.Forms;

namespace HydMobileApp.Page
{
    public class HydTabPage : TabbedPage
    {
        public HydTabPage()
        {
            Children.Add(new HydSliderPage());
            Children.Add(new HydAboutPage());
            Children.Add(new HydContactPage());
            Children.Add(new HydMultiMediaPage());
        }
    }

  
}
