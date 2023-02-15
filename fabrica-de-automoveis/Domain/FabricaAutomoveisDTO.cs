using DTIDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fabrica_de_automoveis.Domain
{
    public class FabricaAutomoveisDTO
    {
        public int id_automovel { get; set; } 

        public string modelo_automovel { get; set; }

        public int ano_automovel { get; set; }
    }
}
