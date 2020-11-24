using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class ContextoCadastro : DbContext
    {
        public DbSet<CadastrarPessoa> CadastrarPessoas { get; set; }

        public ContextoCadastro(DbContextOptions<ContextoCadastro> options) : base(options)
        {

        }
    }
}
