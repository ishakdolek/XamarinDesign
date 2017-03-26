using System.Collections.ObjectModel;

namespace HydMobileApp.Model
{

    public class CarouselImageViewModel
    {
        public ObservableCollection<CarouselImageModel> CarouselImageModels { get; set; }

        public CarouselImageViewModel()
        {
            CarouselImageModels = new ObservableCollection<CarouselImageModel>
            {
                new CarouselImageModel
                {
                    Name="Hayrat",
                    ImageUrl = "orphan.jpg"
                },
                new CarouselImageModel
                {
                    Name = "Yardım",
                    ImageUrl = "quran.jpg"
                }
            };
        }

    }
}
