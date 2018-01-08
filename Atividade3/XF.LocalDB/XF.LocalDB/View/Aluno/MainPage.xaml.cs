using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.LocalDB.ViewModel;

namespace XF.LocalDB.View.Aluno
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.AlunoVM.Carregar();
        } 

        //AlunoViewModel vmAluno;
        //public MainPage()
        //{
        //    vmAluno = new AlunoViewModel();
        //    BindingContext = vmAluno;
        //    InitializeComponent();
        //}
        //protected override void OnAppearing()
        //{
        //    vmAluno = new AlunoViewModel();
        //    BindingContext = vmAluno;
        //    base.OnAppearing();
        //}
        //private void OnNovo(object sender, EventArgs args)
        //{
        //    Navigation.PushAsync(new NovoAlunoView());
        //}
        //private void OnAlunoTapped(object sender, ItemTappedEventArgs args)
        //{
        //    var selecionado = args.Item as
        //    XF.LocalDB.Model.Aluno;
        //    DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        //}
    }
}
