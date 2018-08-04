using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficiona.Dominio
{
    public class VeiculoPasseio : Veiculo
    {
        //ToDo: OO - classe ou abstração.
        //ToDo: OO - Veiculo - Herança.

        public TipoCarroceria Carroceria { get; set; }

        public override List<string> Validar()
        {
            var erros = base.ValidarBase();

            //validar ENUM
            if (!Enum.IsDefined(typeof(TipoCarroceria),Carroceria))
            {
                erros.Add($"A Carrocerinha informada ({Carroceria})não é valida.");
            }

            return erros;
        }
    }
}
