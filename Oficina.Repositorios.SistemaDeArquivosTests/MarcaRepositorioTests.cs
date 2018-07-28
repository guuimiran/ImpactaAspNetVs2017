using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTodosTest()
        {
            var marcaRepositorio = new MarcaRepositorio();

            var marcas = marcaRepositorio.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - {marca.Nome}"); // string interpolada, colocar o $.
            }
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(-1)]
        public void SelecionarPorIdTest(int marcaId)
        {
            var marcaRepositorio = new MarcaRepositorio();

            var marca = marcaRepositorio.Selecionar(marcaId);

            if (marcaId > 0)
            {
                Assert.AreEqual(marca.Nome,"Fiat");
            }

            else
            {
                Assert.IsNull(marca);
            }
        }
    }
}