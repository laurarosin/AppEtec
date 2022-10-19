using AppEtec.Models;
using System;
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

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações problemas.°Estimular a organização. °Incentivar a criatividade."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
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
                    Nome = "Programação de Aplicativos Mobile II",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informações para plataformas móveis.",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. °Incentivar a criatividade. °Estimular a organização"
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
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informações para web",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. °Fortalecer a persistÊncia e o interesse na resolução de situações problemas. °Incentivar a criatividade"
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");   
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria de qualidade de sistemas.°Elaborar registros e planilhas de acompanhamento e controle de atividades.",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. °Estimular a proatividade. °Incentivar comportamentos éticos."

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional",

                    AtribuicoesResponsabilidades = "Atuar de acordo com príncipios éticos na relação do trabalho.",

                    ValoresAtitudes = "Estimular atitudes respeitosas. °Incentivar comportamentos éticos. °Comprometer-se com a igualdade de direitos."
                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var C = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.",

                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. °Demonstrar comprometimentos com a equipe de trabalho."
                };
                await Navigation.PushAsync(new VerComponente(C));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}