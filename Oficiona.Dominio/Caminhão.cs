using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficiona.Dominio
{
    public class Caminhão : Veiculo
    {
        public  QuantidadeEixo QuantidadeEixo { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
