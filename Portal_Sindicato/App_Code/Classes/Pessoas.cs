using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classe
{

    /// <summary>
    /// Descrição resumida de Pessoas
    /// </summary>
    public class Pessoas
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Dataadm { get; set; }
        public DateTime Datadem { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }

        //construtor
        public Pessoas()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}