using Microsoft.Maui.Controls;
using CadastroEvento.Models;

namespace CadastroEvento.Pages
{
    public partial class MainPage : ContentPage
    {
        public Evento Evento { get; set; }
        public Command CadastrarEventoCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Evento = new Evento
            {
                DataInicio = new DateTime(2024, 11, 20),
                DataTermino = new DateTime(2024, 12, 20)
            };

            CadastrarEventoCommand = new Command(OnCadastrarEvento);

            BindingContext = new
            {
                Evento,
                CadastrarEventoCommand
            };
        }

        private async void OnCadastrarEvento()
        {
            await Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}


