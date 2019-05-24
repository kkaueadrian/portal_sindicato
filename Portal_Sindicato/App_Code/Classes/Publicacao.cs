using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classes
{
    /// <summary>
    /// Descrição resumida de Associado
    /// </summary>
    public class Publicacao
    {
        public int Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public int Tipo { get; set; }
        public string Imagem { get; set; }
        public Sindicato Sindicato { get; set; }

    public Publicacao()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}