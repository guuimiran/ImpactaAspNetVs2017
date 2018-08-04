using Oficiona.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class MarcaRepositorio
    {
        private string _caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["caminhoArquivoMarca"]);

        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                //resultado do split.
                var propiedades = linha.Split('|');//no split coloca o seperador que voce está usando.

                var marca = new Marca();

                marca.Id = Convert.ToInt32(propiedades[0]);
                marca.Nome = propiedades[1];

                marcas.Add(marca);
                
            }

            return marcas;
        }

        public Marca Selecionar(int marcaId)
        {
            Marca marca = null;

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                //recuperar os 5 primeiros caracteres.
                var propiedades = linha.Split('|'); // 0 é onde comeca, e o 5 é o tamanho.

                if (propiedades[0] == marcaId.ToString())
                {
                    marca = new Marca();

                    //preencher o objeto marca.
                    marca.Id = marcaId;
                    marca.Nome = propiedades[1];

                    //pegar so uma linha.
                    break;
                }
            }
            return marca;
        }
    }
}
