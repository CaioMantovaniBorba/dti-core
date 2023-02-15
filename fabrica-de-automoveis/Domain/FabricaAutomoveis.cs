using DTIDomain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fabrica_de_automoveis.Domain
{
    public class FabricaAutomoveis : DomainBase
    {
        public int id_automovel { get; set; }

        public string modelo_automovel { get; set; }

        public int ano_automovel { get; set; }

        public override void Validar()
        {
            _regrasQuebradas.Clear();
            if (String.IsNullOrEmpty(modelo_automovel))
                _regrasQuebradas.Add("O modelo não pode ser vazio");
            if (ano_automovel <= 0)
                _regrasQuebradas.Add("O código não deve ser maior que 0");
        }
    }
}
