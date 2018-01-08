using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XF.LocalDB.View.Login
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            txtUsuario.Text = pwdSenha.Text = string.Empty;
            base.OnAppearing();
        }  
    }
}
