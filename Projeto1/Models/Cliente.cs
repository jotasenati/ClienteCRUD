using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto1.Models
{
    public class Cliente
    {
        [Key()]
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Salario { get; set; }
        public DateTime DataCadastro { get; set; }
        public Nullable<DateTime> DataAlteracao { get; set; }
        public Nullable<DateTime> DataExcluido { get; set; }

    }
}