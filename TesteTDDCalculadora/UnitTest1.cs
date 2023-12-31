using System;
using Xunit;
using TDDCalculadora;


namespace TesteTDDCalculadora
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            return new Calculadora("12/11/2000");
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int valorUm, int valorDois, int valorResultado)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.somar(valorUm, valorDois);

            Assert.Equal(valorResultado, resultado);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int valorUm, int valorDois, int valorResultado)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.subtrair(valorUm, valorDois);

            Assert.Equal(valorResultado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int valorUm, int valorDois, int valorResultado)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.multiplicar(valorUm, valorDois);

            Assert.Equal(valorResultado, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int valorUm, int valorDois, int valorResultado)
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.dividir(valorUm, valorDois);

            Assert.Equal(valorResultado, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = construirClasse();

            calculadora.somar(1, 1);
            calculadora.somar(1, 1);
            calculadora.somar(1, 1);
            calculadora.somar(1, 1);

            var lista = calculadora.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
