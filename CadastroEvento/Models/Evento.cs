﻿using System;

namespace CadastroEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        public int DuracaoEmDias => (DataTermino - DataInicio).Days;
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
