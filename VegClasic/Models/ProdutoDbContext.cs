namespace VegClasic.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext()
            : base("name=DefaultConnection")
        {
        }   
        
        public virtual DbSet<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string caminhoImg { get; set; }
    }
}