using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{

    public class Logon
    {
        public int Codigo { get; set; }
        public DateTime Tempo { get; set; }
        public Pessoa Pessoa { get; set; }

        public Logon()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }

}