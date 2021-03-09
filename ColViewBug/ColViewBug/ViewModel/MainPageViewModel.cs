using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ColViewBug.ViewModel
{
    public class MainPageViewModel : ObservableObject
    {
        List<TestData> col;
        bool isLoading;
        ContentPage MyPage;

        public bool IsLoading
        {
            get => isLoading;
            set => SetProperty(ref isLoading, value);
        }

        public List<TestData> Col
        {
            get => col;
            set => SetProperty(ref col, value);
        }

        public MainPageViewModel(ContentPage page)
        {
            MyPage = page;
            LoadData();
        }

        private void LoadData()
        {
            Col = new List<TestData>()
            {
                new TestData()
                {
                    Row1Text = "Test One",
                    Row1SubText = "sub text one",
                    Row2Text = "Some More Information"
                },
                new TestData()
                {
                    Row1Text = "Test Two",
                    Row1SubText = "sub text two",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Three",
                    Row1SubText = "sub text three",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Four",
                    Row1SubText = "sub text four",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Five",
                    Row1SubText = "sub text five",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Six",
                    Row1SubText = "sub text six",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Seven",
                    Row1SubText = "sub text seven",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Eight",
                    Row1SubText = "sub text eight",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Nine",
                    Row1SubText = "sub text nine",
                    Row2Text = "Some More Informatino"
                },
                new TestData()
                {
                    Row1Text = "Test Ten",
                    Row1SubText = "sub text ten",
                    Row2Text = "Some More Informatino"
                },
            };

            IsLoading = false;
        }

        public ICommand TapGestCommand => new AsyncCommand(TapGestAsync);
        public ICommand DeleteCommand => new AsyncCommand(DeleteAsync);
        public ICommand SendCommand => new AsyncCommand(SendAsync);
        public ICommand ConvertCommand => new AsyncCommand(ConvertAsync);
        public ICommand SaveCommand => new AsyncCommand(SaveAsync);
        public ICommand RefreshCommand => new AsyncCommand(RefreshAsync);

        private async Task TapGestAsync()
        {
            await MyPage.DisplayAlert("Tap Command", "List item tapped", "Ok");
        }

        private async Task DeleteAsync()
        {
            await MyPage.DisplayAlert("Delete Command", "delete button tapped", "Ok");
        }

        private async Task SendAsync()
        {
            await MyPage.DisplayAlert("Send Command", "send button tapped", "Ok");
        }
        private async Task ConvertAsync()
        {
            await MyPage.DisplayAlert("Convert Command", "convert button tapped", "Ok");
        }
        private async Task SaveAsync()
        {
            await MyPage.DisplayAlert("Save Command", "save button tapped", "Ok");
        }

        private async Task RefreshAsync()
        {
            await MyPage.DisplayAlert("Refresh Command", "Refreshing view", "Ok");
            Col.Clear();
            LoadData();
        }

    }

    public class TestData
    {
        public string Row1Text { get; set; }
        public string Row1SubText { get; set; }
        public string Row2Text { get; set; }
        public string Row3Text { get; set; }
    }
}
