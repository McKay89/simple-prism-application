using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PrismApp.Views
{
    public partial class BodyRightView : UserControl
    {
        private static Image _image = new();

        public BodyRightView()
        {
            InitializeComponent();
            _image = Browsed_Image;
        }

        public static void SetImage(string imagePath)
        {
            _image.Source = new BitmapImage(new Uri(imagePath));
        }
    }
}
