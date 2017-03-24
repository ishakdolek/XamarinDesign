using System.Collections.ObjectModel;
using HydMobileApp.Model.Menu;

namespace HydMobileApp.Data
{
   public static class MenuDataBinding
    {

       public static ObservableCollection<MenuModel> BindMenu()
       {
            return new ObservableCollection<MenuModel>
              {
                  new MenuModel {Id = 1, Name = "Anasayfa",ImageUrl=""},
                  new MenuModel {Id = 2, Name = "Kurumsal",ImageUrl=""},
                  new MenuModel {Id = 3, Name = "Projeler",ImageUrl=""},
                  new MenuModel {Id = 4, Name = "Haberler",ImageUrl=""},
                  new MenuModel {Id = 5, Name = "Duyurular",ImageUrl=""},
                  new MenuModel {Id = 6, Name = "Bağış Yap",ImageUrl=""},
                  new MenuModel {Id = 7, Name = "Hakkımızda",ImageUrl=""},
                  new MenuModel {Id = 8, Name = "İletişim",ImageUrl = ""}
              };
        }
    }
}
