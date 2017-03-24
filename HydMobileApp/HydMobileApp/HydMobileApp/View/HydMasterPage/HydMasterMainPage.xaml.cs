using HydMobileApp.Model.Menu;
using HydMobileApp.Page;
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
    }
}
