using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classe
{

    /// <summary>
    /// Descrição resumida de Funcionario
    /// </summary>
    public class Funcionario
    {
        //propriedades
        public int Codigo { get; set; }
        public Boolean permissao_administrador { get; set; }
        public int set_codigo { get; set; }
        public int pes_codigo { get; set; }
        public int sin_codigo { get; set; }

        //construtor
        public Funcionario()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}