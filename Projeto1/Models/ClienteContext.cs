using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto1.Models
{

    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("Clientes") { }
        public  DbSet<Cliente> Clientes { get; set; }    

    }
}