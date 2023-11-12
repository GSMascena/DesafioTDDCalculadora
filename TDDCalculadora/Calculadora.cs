using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCalculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private const int limiteHistorico = 3;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int somar(int valorUm, int valorDois)
        {
            return executarOperacao(valorUm + valorDois);
        }

        public int subtrair(int valorUm, int valorDois)
        {
            return executarOperacao(valorUm - valorDois);
        }

        public int multiplicar(int valorUm, int valorDois)
        {
            return executarOperacao(valorUm * valorDois);
        }

        public int dividir(int valorUm, int valorDois)
        {
            return executarOperacao(valorUm / valorDois);
        }

        private int executarOperacao(int resultado)
        {
            listaHistorico.Insert(0,"Resultado: " + resultado);
            return resultado;
        }

        public List<String> historico()
        {
            listaHistorico.RemoveRange(limiteHistorico, listaHistorico.Count - limiteHistorico);
            return listaHistorico;
        }
    }
}
