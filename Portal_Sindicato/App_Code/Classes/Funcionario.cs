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
        public int Codigo { get; set; }
        public Boolean PermissaoAdministrador { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Dataadm { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public Sindicato Sindicato { get; set; }
        public Setor Setor { get; set; }
        public int Tipo { get; set; }


        //construtor
        public Funcionario()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}