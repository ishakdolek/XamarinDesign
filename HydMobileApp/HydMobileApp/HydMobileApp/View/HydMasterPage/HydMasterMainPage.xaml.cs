using System;
using HydMobileApp.Model.Menu;
using HydMobileApp.Page;
using HydMobileApp.View.Slider;
using Xamarin.Forms;
namespace HydMobileApp.View.HydMasterPage
{
    public partial class HydMasterMainPage : ContentPage
    {
        public HydMasterMainPage()
        {
            InitializeComponent();
            listMenu.BindingContext = new MenuModelView();
        }

        private void ListMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem as MenuModel;
            //if (item!=null)
            //{
            //    //_hydMasterPage.Detail= new NavigationPage((Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType));
            //    //Navigation.PushAsync((Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType));
            //    //_hydMasterPage.Detail=  Navigation.PushAsync((Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType));
            //    //Eğer bir nesne seçildikten sonra menu'yu kapatmak istiyorsanız..
            //    var mdPage = (Page.HydMasterPage)this.Parent;
            //    var ite12=
            //    detailPage= new NavigationPage((Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType));
            //    //Navigation.PushAsync((Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType));
            //    mdPage.IsPresented = false;
            //    //Eğer bir nesne seçildikten sonra, seçtiğiniz nesne üzerindeki "selected" özelliğini kaldırmak istiyorsanız..
            //    var lstMenu = (ListView)sender;
            //    lstMenu.SelectedItem = null;

            //}
        }
    }
}
