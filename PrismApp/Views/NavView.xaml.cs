using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace PrismApp.Views
{
    public partial class NavView : UserControl
    {
        public NavView()
        {
            InitializeComponent();
        }

        private void Browse_Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Képfájlok (*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png|Minden fájl|*.*";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string selectedFilePath = openFileDialog.FileName;

                BodyRightView.SetImage(selectedFilePath);
                FooterView.SetImagePathText(selectedFilePath);
                BodyLeftView.SetSmileyVisible();
            }
        }

        private void Info_Btn_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            ModalDialog dialogWindow = new()
            {
                Owner = parentWindow
            };
            dialogWindow.ShowDialog();
        }
    }
}
