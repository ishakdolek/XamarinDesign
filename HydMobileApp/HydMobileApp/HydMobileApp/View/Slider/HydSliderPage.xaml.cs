using HydMobileApp.Model;
using Xamarin.Forms;

namespace HydMobileApp.View.Slider
{
    public partial class HydSliderPage : ContentPage
    {
        private readonly CarouselImageViewModel _carouselImage;
        public HydSliderPage()
        {
            _carouselImage = new CarouselImageViewModel();
            InitializeComponent();
            Slider.ItemsSource = _carouselImage.CarouselImageModels;
        }
    }
}
