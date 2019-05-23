using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{

    /// <summary>
    /// Descrição resumida de Funcionario
    /// </summary>
    public class Funcionario:Pessoa
    {
        //propriedades
        
        public Boolean PermissaoAdministrador { get; set; }
        public Sindicato Sindicato { get; set; }
        public Setor Setor { get; set; }
        


        //construtor
        public Funcionario()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}