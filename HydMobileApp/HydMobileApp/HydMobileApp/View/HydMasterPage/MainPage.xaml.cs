using System;
using HydMobileApp.Model.Menu;
using HydMobileApp.View.Slider;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HydMobileApp.View.HydMasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationDrawerList.BindingContext = new MenuModelView();
            Detail = new NavigationPage((Xamarin.Forms.Page)Activator.CreateInstance(typeof(HydSliderPage)));
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MenuModel)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Xamarin.Forms.Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
