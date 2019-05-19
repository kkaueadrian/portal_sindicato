using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{

    /// <summary>
    /// Descrição resumida de Pessoas
    /// </summary>
    public class Pessoa
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Dataadm { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }

        //construtor
        public Pessoa()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}