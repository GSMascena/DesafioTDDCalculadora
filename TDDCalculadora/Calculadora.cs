using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCalculadora
{
    public class Calculadora
    {
        public int somar(int valorUm, int valorDois)
        {
            return valorUm + valorDois;
        }

        public int subtrair(int valorUm, int valorDois)
        {
            return valorUm - valorDois;
        }

        public int multiplicar(int valorUm, int valorDois)
        {
            return valorUm * valorDois;
        }

        public int dividir(int valorUm, int valorDois)
        {
            return valorUm / valorDois;
        }

        public List<String> histórico()
        {
            return new List<string>();
        }
    }
}
