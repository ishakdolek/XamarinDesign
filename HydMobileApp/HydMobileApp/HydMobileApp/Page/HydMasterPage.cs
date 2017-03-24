using HydMobileApp.View.HydMasterPage;
using HydMobileApp.View.Slider;
using Xamarin.Forms;

namespace HydMobileApp.Page
{
   public class HydMasterPage:MasterDetailPage
    {
       public HydMasterPage()
       {
           Title = "HAYRAT YARDIM";
           Master=new  HydMasterMainPage();
           //Detail= new HydTabPage();
           Detail= new HydSliderPage();
       }
       
    }
}
