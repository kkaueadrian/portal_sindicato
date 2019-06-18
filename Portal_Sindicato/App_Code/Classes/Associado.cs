using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{
    /// <summary>
    /// Descrição resumida de Associado
    /// </summary>
    public class Associado:Pessoa
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Caepf { get; set; }
        public Sindicato Sindicato { get; set; }
        public Boolean Status { get; set; }




        public Associado()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}