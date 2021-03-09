using ColViewBug.ViewModel;
using System;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColViewBug
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel(this);
        }

        private async void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            //await DisplayAlert("Swipe started", "Starting swipe action","Ok");

            if (!string.IsNullOrEmpty(outputLabel.Text))
                outputLabel.Text += $"{Environment.NewLine} Swipe Started";
            else
                outputLabel.Text = "Swipe Started";
        }

        private async void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            //await DisplayAlert("Swipe changing", "Changing swipe action", "Ok");
            if (!string.IsNullOrEmpty(outputLabel.Text))
                outputLabel.Text += $"{Environment.NewLine} Change Started";
            else
                outputLabel.Text += "Change Started";
        }

        private async void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            //await DisplayAlert("Swipe ended", $"{e.IsOpen} Ending swipe", "Ok");
            if (!string.IsNullOrEmpty(outputLabel.Text))
                outputLabel.Text += $"{Environment.NewLine} Swipe Ended";
            else
                outputLabel.Text += "Swipe Ended";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
    }
}
