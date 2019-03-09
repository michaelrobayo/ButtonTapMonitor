using System.Threading;
using Xamarin.Forms;

namespace ButtonTapCounter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int _count = 0;

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            _count++;
            ((Button)sender).Text = $"You clicked {_count} times.";
        }
    }
}
