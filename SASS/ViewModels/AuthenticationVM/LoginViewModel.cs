using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SASS.Services.AuthenticationSevices;
using SASS.Services;
using SASS.Models;

namespace SASS.ViewModels.AuthenticationVM
{
   public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string password;

        DataBaseSQLite sQLite = new DataBaseSQLite();
        public Command SignIn { get; }
        public Command Login { get; }


        public LoginViewModel()
        {
            SignIn = new Command(OnSignIn);
            Login = new Command(OnLogin);
        }



        public string Username
        {
            get => username;
            set
            {
                SetProperty(ref username, value);
                OnPropertyChanged(nameof(Username));

            }
        }

        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
                OnPropertyChanged(nameof(Password));
            }
        }










        async void OnLogin()
        {
            await Shell.Current.GoToAsync("//TabView");
            /* Use For DataBase
             * 
             * 
            IUserData<User> userData = new UserData(sQLite.Url);

            if (userData.GetUser(Username, Password) != null)
            {
                await Shell.Current.DisplayAlert("Congrats", "Login Successful", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Alert", "Wrong password", "OK");
            }
            */
        }



        async void OnSignIn()
        {
            try
            {

            await Shell.Current.GoToAsync("SignInPage");
            }catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }

        }










    }
}
