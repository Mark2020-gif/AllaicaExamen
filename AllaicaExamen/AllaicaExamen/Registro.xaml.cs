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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double pagoinicial = Convert.ToDouble(txtMontoinicial.Text);
                double montomensual = Convert.ToDouble(txtPagoMensual.Text);

                double cuota = ((montomensual + 90) * 5) + pagoinicial;
                txtPagoMensual.Text = cuota.ToString();


                await DisplayAlert("RESUMEN", "REGISTRO EXITOSO", "Aceptar");
                await Navigation.PushAsync(new Resumen(txtNombre.Text, txtPagoMensual.Text));




            }
            catch (Exception ex)
            {
                 await DisplayAlert("Mensaje de alerta ", ex.Message, "OK");
            }

        }
    }
}