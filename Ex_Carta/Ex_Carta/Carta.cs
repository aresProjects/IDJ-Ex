﻿using System.Diagnostics.Tracing;

namespace Ex_Carta
{
    public class Carta
    {
        private string Nome { get; set; }
        public Naipe naipes { get; set; }

        public Carta(string n, Naipe naipe)
        {
            Nome = n;
            naipes = naipe;
        }
    }
}