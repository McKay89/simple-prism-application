using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PrismApp.Views
{
    public partial class BodyLeftView : UserControl
    {
        private readonly DateTime actualDate = DateTime.Now;
        private static Image _smiley = new();
        private static Visibility VisibilityOfPicture = Visibility.Visible;

        public BodyLeftView()
        {
            InitializeComponent();

            Actual_Date_Text.Text = actualDate.ToString();
            _smiley = Smiley_Image;
        }

        public static void SetSmileyVisible()
        {
            _smiley.Visibility = VisibilityOfPicture;
        }
    }
}
