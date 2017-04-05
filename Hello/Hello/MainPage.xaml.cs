using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            goBtn.Clicked += async (sender, args) => {
                await NextPageAsync();
            };
            
        }

        private async Task NextPageAsync()
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Navigation.RemovePage(this);
        }

    }
}
