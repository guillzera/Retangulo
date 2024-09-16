﻿namespace Retangulo.Models
{
    public class Retan
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return Altura * 2 + Largura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
