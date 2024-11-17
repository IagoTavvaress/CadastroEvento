using Microsoft.Maui.Controls;
using CadastroEvento.Models;

namespace CadastroEvento.Pages
{
    public partial class ResumoEventoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            Evento = evento;
            BindingContext = Evento;
        }
    }
}
