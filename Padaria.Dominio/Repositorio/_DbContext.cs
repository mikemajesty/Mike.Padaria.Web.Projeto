using Padaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria.Dominio.Repositorio
{
    public class _DbContext : DbContext
    {
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Data> Data { get; set; }
        public DbSet<Fiado> Fiado { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaComComandaAtiva> VendaComComandaAtiva { get; set; }
        public DbSet<Permissao> Permissao { get; set; }

        protected override void OnModelCreating(DbModelBuilder banco)
        {
            banco.Conventions.Remove<PluralizingTableNameConvention>();
            banco.Entity<Caixa>().ToTable("Caixa");
            banco.Entity<Categoria>().ToTable("Categoria");
            banco.Entity<Cliente>().ToTable("Cliente");
            banco.Entity<Comanda>().ToTable("Comanda");
            banco.Entity<Data>().ToTable("Data");
            banco.Entity<Fiado>().ToTable("Fiado");
            banco.Entity<Produto>().ToTable("Produto");
            banco.Entity<TipoPagamento>().ToTable("TipoPagamento");
            banco.Entity<Usuarios>().ToTable("Usuarios");
            banco.Entity<Venda>().ToTable("Venda");
            banco.Entity<VendaComComandaAtiva>().ToTable("VendaComComandaAtiva");
            banco.Entity<Permissao>().ToTable("Permissao");
            base.OnModelCreating(banco);
        }
    }
}
