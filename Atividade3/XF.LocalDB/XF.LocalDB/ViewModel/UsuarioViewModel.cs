﻿using System;
using System.Windows.Input;
using Xamarin.Forms;
using XF.LocalDB.Model;
using System.Net.Http;

namespace XF.LocalDB.ViewModel
{
    public class UsuarioViewModel
    {
        #region Propriedade
        public Usuario UsuarioModel { get; set; }
        public string Nome { get; set; }
        public string Stream { get; set; }

        // UI Events
        public IsAutenticarCMD IsAutenticarCMD { get; }
        #endregion

        public UsuarioViewModel()
        {
            UsuarioModel = new Usuario();
            IsAutenticarCMD = new IsAutenticarCMD(this);
            this.GetUsuarios("http://wopek.com.spiraea.arvixe.com/xml/usuarios.xml");
        }

        public void IsAutenticar(Usuario paramUser)
        {
            this.Nome = paramUser.Username;
            //if (UsuarioRepository.IsAutorizado(paramUser))
            App.Current.MainPage.Navigation.PushAsync(
                new View.Aluno.MainPage() { BindingContext = App.AlunoVM });
            //else
            //App.Current.MainPage.DisplayAlert("Atenção", "Usuário não autorizado", "Ok");
        }

        private async void GetUsuarios(string paramURL)
        {
            var httpRequest = new HttpClient();
            Stream = await httpRequest.GetStringAsync(paramURL);
        }
    }

    public class IsAutenticarCMD : ICommand
    {
        private UsuarioViewModel usuarioVM;
        public IsAutenticarCMD(UsuarioViewModel paramVM)
        {
            usuarioVM = paramVM;
        }
        public event EventHandler CanExecuteChanged;
        public void DeleteCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public bool CanExecute(object parameter)
        {
            if (parameter != null) return true;

            return false;
        }
        public void Execute(object parameter)
        {
            usuarioVM.IsAutenticar(parameter as Usuario);
        }
    }
}