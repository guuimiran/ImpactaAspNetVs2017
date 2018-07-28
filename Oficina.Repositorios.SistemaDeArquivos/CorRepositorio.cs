using Oficiona.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;


namespace Oficina.Repositorios.SistemaDeArquivos
{
    public class CorRepositorio
    {
        private string _caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                var cor = new Cor();

                cor.Id = Convert.ToInt32(linha.Substring(0,5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }

            return cores;
        }      


        public Cor Selecionar(int corId)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(_caminhoArquivo))
            {
                //recuperar os 5 primeiros caracteres.
                var linhaId = Convert.ToInt32(linha.Substring(0,5)); // 0 é onde comeca, e o 5 é o tamanho.

                
                if (linhaId == corId)
                {
                    cor = new Cor();

                    //preencher o objeto cor.
                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);

                    //pegar so uma linha.
                    break;
                }
            }

            return cor;
        }
    }
}
