using Xamarin.Forms;

namespace Badshah
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Browser.Source = "https://twitter.com/bnchandrapal";
        }
    }
}
