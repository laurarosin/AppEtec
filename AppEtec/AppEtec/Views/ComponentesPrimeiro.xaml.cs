using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e" +
                                                    "elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o diálogo e a interlocução. ° Responsabilizar-se pela produção, utilização e" +
                                       "divulgação de informações. °Estimular a proatividade"
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
                    Nome = "Programação e Algoritmos",

                    AtribuicoesResponsabilidades = "°Implementar Algoritmos em linguagem de programação, utilizando ambientes de" +
                                                    "desenvolvimento de acordo com as necessidades",

                    ValoresAtitudes = "°Estimular a organização. °Incentivar atitudes de autonomia. °Fortalecer a persistência" +
                                      "e o interesse na resolução de situação-problema"

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK!");
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