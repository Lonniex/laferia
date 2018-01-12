using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;


namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReminderPage 
    {
        public ReminderPage()
        {
            InitializeComponent();
        }

        async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
         }

        
         async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            await Navigation.PushAsync(new LoginPage());

        }
    }
}