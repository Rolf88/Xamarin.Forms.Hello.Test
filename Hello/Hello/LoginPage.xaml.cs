using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello
{
    
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            btnLogin.Clicked += async (sender, args) => {
                var email = editEmail.Text;
                var password = editPassword.Text;

                if ((email != null && password != null) && (!email.Equals("") && !password.Equals("")))
                {
                    await Navigation.PushAsync(new Hello.MainPage());
                }
            };
        }
    }
}
