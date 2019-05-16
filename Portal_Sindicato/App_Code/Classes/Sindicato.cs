using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{
    /// <summary>
    /// Descrição resumida de Sindicato
    /// </summary>
    public class Sindicato
    {

        public int Codigo { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public bool Ativo { get; set; }



        public Sindicato()
        {

        }
    }
}