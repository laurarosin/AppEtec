using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppEtec.Models;

namespace AppEtec.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Istrumental",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira - inglês, utilizando o vocabulário e a termionologia da área ",

                    ValoresAtitudes = "Respeitar as manifestações culturais de outros povos. °Estimular a comunicação nas relações interpessoais. °Socializar os saberes."


                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
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
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. °Codificar e depurar programas.",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações problema.°Incentivar ações que promovam a cooperação.°Desenvolver a criatividade."

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "Implementar banco de dados",

                    ValoresAtitudes = "Incentivar a criatividade. °Desenvolver a criatividade. °Fortalecer a persistência e o interesse na resolução de situações problema."

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet e Protocolos",

                    AtribuicoesResponsabilidades = "Utilizar protocolos de redes e internet para a comunicação de dados",

                    ValoresAtitudes = "Incentivar comportamentos éticos. °Promover acções que considerem o respeito ás normas estabelecidas. °Fortalecer a persistência e o interesse na resolução de situações problema"

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I",

                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis",

                    ValoresAtitudes = "Incentivar a criatividade. ° Responsabilizar-se pela produção, utilização e divulgação de informações. ° Estimular a organização"
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "ok");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação web",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilizando a divulgação de informações."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Ops!", ex.Message, "Ok");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Planejamento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Planejar Projetos de Sistemas Computacionais",

                    ValoresAtitudes = "Comunicar-se com a equipe com clareza e objetividade. °Organizar procedimentos de maneira diversa, visando melhor eficiência"
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}