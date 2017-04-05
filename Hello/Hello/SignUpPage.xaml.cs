using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello
{

    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();

            goBtn.Clicked += async (s,a) => {
                await PagerTest();
            };
        }

        private async Task PagerTest() {
            await Navigation.PopAsync();
            //IReadOnlyList<Page> navStack = Navigation.NavigationStack;
            //Page pageC = navStack[navStack.Count - 1];
            //Navigation.RemovePage(pageC);
        }

    }
}
