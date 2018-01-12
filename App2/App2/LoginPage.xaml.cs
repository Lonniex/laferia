using App2.Modes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        ListView tView;

        public LoginPage()
        {
            InitializeComponent();
            usernameEntry.Text = "";
            passwordEntry.Text = "";
            emailEntry.Text = "";
            Init();
        }

        void Init()
        {
            usernameEntry.Completed += (s, e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => OnSignUpButtonClicked(s, e);
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }



        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            User user = new User(usernameEntry.Text, passwordEntry.Text, emailEntry.Text);
                         
              PrintTable();

            if (user.CheckInformation())
            {
                App.IsUserLoggedIn = true;
                await Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                messageLabel.Text = "Datos Erróneos";
                passwordEntry.Text = string.Empty;
            }
        }
                    
        void PrintTable()
        {
            IList ListOfUsers;

            ListOfUsers = App.UserDatabase.GetAllUsers();
            Debug.WriteLine("List is as follows");
            foreach (var IUserList in ListOfUsers)
            {
                Debug.WriteLine(IUserList);

            }
        }
    }

}