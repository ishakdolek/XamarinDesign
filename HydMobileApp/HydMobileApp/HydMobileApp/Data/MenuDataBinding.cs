using System.Collections.ObjectModel;
using HydMobileApp.Model.Menu;
using HydMobileApp.View.HydTabPages;
using HydMobileApp.View.Slider;
using HydMobileApp.View.StaticPage;

namespace HydMobileApp.Data
{
   public static class MenuDataBinding
    {

       public static ObservableCollection<MenuModel> BindMenu()
       {
            return new ObservableCollection<MenuModel>
              {
                  new MenuModel {Id = 1, Name = "Anasayfa",ImageUrl="",TargetType = typeof(HydSliderPage)},
                  new MenuModel {Id = 2, Name = "Kurumsal",ImageUrl="",TargetType = typeof(HydAboutPage)},
                  new MenuModel {Id = 3, Name = "Projeler",ImageUrl="",TargetType = typeof(HydProjectPage)},
                  new MenuModel {Id = 4, Name = "Haberler",ImageUrl="",TargetType = typeof(HydNewsPage)},
                  new MenuModel {Id = 5, Name = "Duyurular",ImageUrl="",TargetType = typeof(HydAnnouncementsPage)},
                  new MenuModel {Id = 6, Name = "Bağış Yap",ImageUrl="",TargetType = typeof(HydDonationPage)},
                  new MenuModel {Id = 8, Name = "İletişim", ImageUrl = "",TargetType = typeof(HydContactPage)}
              };
        }
    }
    
}
