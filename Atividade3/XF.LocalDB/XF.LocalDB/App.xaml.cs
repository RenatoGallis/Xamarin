using Xamarin.Forms;
using XF.LocalDB.ViewModel;

using XF.LocalDB.Model;

namespace XF.LocalDB
{
    public partial class App : Application
    {
        public static AlunoViewModel AlunoVM { get; set; }
        public static UsuarioViewModel UsuarioVM { get; set; }

        public App()
        {
            InitializeComponent();
            InitializeApplication();

            MainPage = new NavigationPage(new View.Login.LoginView() { BindingContext = App.UsuarioVM });
        }

        private void InitializeApplication()
        {
            if (AlunoVM == null) AlunoVM = new AlunoViewModel();
            if (UsuarioVM == null) UsuarioVM = new UsuarioViewModel();
        }

        //static Aluno alunoModel;
        //public static Aluno AlunoModel
        //{
        //    get
        //    {
        //        if (alunoModel == null)
        //        {
        //            alunoModel = new Aluno();
        //        }
        //        return alunoModel;
        //    }
        //}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
