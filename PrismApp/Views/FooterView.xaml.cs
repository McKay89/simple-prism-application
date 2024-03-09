using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace PrismApp.Views
{    
    public partial class FooterView : UserControl
    {
        private static TextBlock _imagePathText = new();

        public FooterView()
        {
            InitializeComponent();
            _imagePathText = Image_Path_Text;
        }

        public static void SetImagePathText(string imagePath)
        {
            Trace.WriteLine(imagePath);
            _imagePathText.Text = imagePath.ToString();
        }
    }
}
