using BottomNavigationBar.Listeners;
using HydMobileApp.View.HydTabPages;
using Xamarin.Forms.Platform.Android;

namespace HydMobileApp.Droid.DeviceRenderer
{
 public   class HydTabbedPageRenderer : VisualElementRenderer<HydMainPage>, IOnTabClickListener
    {
     public void OnTabSelected(int position)
     {
         throw new System.NotImplementedException();
     }

     public void OnTabReSelected(int position)
     {
         throw new System.NotImplementedException();
     }
    }
}