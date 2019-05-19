using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{


    /// <summary>
    /// Descrição resumida de Pendencia
    /// </summary>
    public class Pendencia
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public Funcionario Funcionario { get; set; }



        public Pendencia()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}