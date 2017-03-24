using Android.Content;
using Android.Views;
using Android.Widget;
using HydMobileApp.Controller;
using HydMobileApp.Droid.DeviceRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof (CustomImageCell), typeof (CustomImageCellRenderer))]
namespace HydMobileApp.Droid.DeviceRenderer
{
    public class CustomImageCellRenderer : ImageCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell = (LinearLayout)base.GetCellCore(item, convertView, parent, context);
            var image = (ImageView)cell.GetChildAt(0);
            image.SetScaleType(ImageView.ScaleType.Center);
            return cell;
        }
    }
}