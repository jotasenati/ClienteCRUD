using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Projeto1.Models
{
    public class ClienteMapper : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapper()
        {
            //Primary Key
            this.HasKey(t => t.CodCliente);


            //Table & Column Mappings 
            this.ToTable("Cliente");
            this.Property(t => t.CodCliente).HasColumnName("CodCliente");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CPF).HasColumnName("CPF");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.Celular).HasColumnName("Celular");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Sexo).HasColumnName("Sexo");
            this.Property(t => t.EstadoCivil).HasColumnName("EstadoCivil");
            this.Property(t => t.Salario).HasColumnName("Salario");

        }
    }
}