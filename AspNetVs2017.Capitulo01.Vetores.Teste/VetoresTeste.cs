using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AspNetVs2017.Capitulo01.Vetores.Teste
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];

            strings[0] = "Vitor";

            var decimais = new decimal[] { 0.5m, 1.59m };

            int[] inteiros = { 1,2,4,5,64};
            foreach (var inteiro in inteiros)
            {
                Console.WriteLine(inteiro);
            }

            Console.WriteLine($"Tamanho do Vetor: {inteiros.Length}");
        }


        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1.59m };

            Array.Resize(ref decimais, 5);
            decimais[4] = 2.1m;
        }


        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m,1, 1.59m,0.4m };

            Array.Sort(decimais);

            Assert.AreNotEqual(decimais[0], 0.4m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };

            Console.WriteLine(Media(decimais));
        }

        //private decimal Media(decimal valor1, decimal valor2)
        //{
        //    return (valor1 + valor2) / 2;
        //}

        private decimal Media(decimal[] decimais)
        {
            var soma = 0m;
            foreach (var @decimal in decimais)
            {
                soma += @decimal;
                
            }

            return soma / decimais.Length;
        }


        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Vitor";

            foreach (var caractere in nome)
            {
                Console.WriteLine(caractere);
            }

            Assert.AreEqual(nome.First(), 'V');
        }
    }
}
