using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Atividade1
{
    public partial class Atividade1Page : ContentPage
    {
        Email email;

        public Atividade1Page()
        {
            InitializeComponent();

            if (email == null)
                email = new Email();
        }

        void btnEnviar_Clicked(object sender, EventArgs args)
        {
            if ((email.Ativo) && (!string.IsNullOrEmpty(email.ContaEmail)))
                DisplayAlert("Mensagem", $"E-mail enviado para {email.ContaEmail}", "Ok");
            //else if ((email.Ativo) && (string.IsNullOrEmpty(email.ContaEmail)))
                //DisplayAlert("Mensagem", $"E-mail invalido", "Ok");
            else
                DisplayAlert("Mensagem", "E-mail não autorizado", "Ok");
        }

        void btnConfig_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ConfigPage(){ BindingContext = email });
        }
    }
}
