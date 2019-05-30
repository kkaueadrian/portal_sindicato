using classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{
    /// <summary>
    /// Descrição resumida de Servico
    /// </summary>
    public class Servico
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Boolean Status { get; set; }
        public string Tipo { get; set; } 
        public Setor Setor { get; set; }


        public Servico()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}