using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllaicaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if ((sUsuario == "estudiante2021") && (sPassword == "uisrael2021"))
            {
                Navigation.PushAsync(new Registro());
            }
            else
            {
                lblResultado.Text = "El usuario o Password es incorrecto";
            }

        }
    }
}