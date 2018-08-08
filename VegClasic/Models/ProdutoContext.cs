namespace VegClasic.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class ProdutoContext : DbContext
    {
        // Your context has been configured to use a 'ProdutoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'VegClasic.Models.ProdutoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProdutoContext' 
        // connection string in the application configuration file.
        public ProdutoContext()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
    }
}