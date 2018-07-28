using Oficiona.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class VeiculoRepositorio
    {
        private string _caminhoArquivo;

        private XDocument _arquivoXml; //carregar o arquivo xml.

        //construtor - é um gatilho, é executado automaticamente
        public VeiculoRepositorio()
        {
            _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];

            _arquivoXml = XDocument.Load(_caminhoArquivo);//carregar o arquivo xml.
        }


        public void Inserir(Veiculo veiculo)
        {
            var registro = new StringWriter();
            new XmlSerializer(typeof(Veiculo)).Serialize(registro, veiculo);

            //ADICIONAR O VEICULO NO XML.
            _arquivoXml.Root.Add(XElement.Parse(registro.ToString())); //CHAMAR O METODO PARSE PARA VER SE O XML ESTA BEM FORMADO.

            _arquivoXml.Save(_caminhoArquivo);
        }
    }
}
