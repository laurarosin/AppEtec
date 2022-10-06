using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEtec.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistema de Informação",

                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança de informação",

                    ValoresAtitudes = "Estimular atitudes respeitosas. °Incentivar comportamentos éticos.°Desenvolver a criatividade."

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados III",

                    AtribuicoesResponsabilidades = "Realizar gestão de banco de dados",

                    ValoresAtitudes = "Incentivar a criatividade. °Desenvolver a criatividade.°Fortalecer a persistência e o interesse na resolução de situações problemas."

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

        }
    }
}