using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EntityFramework.Entities
{
    //Define o nome da tabela
    //[Table("Pessoas")]
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; } 
        public int idade { get; set; }

        public static void Map(DbModelBuilder modelBuilder)
        {
            //Outra forma de definir o nome da tabela
            modelBuilder.Entity<Pessoa>().ToTable("Pessoas");

            //Define um nome persinalizado para uma coluna
            modelBuilder.Entity<Pessoa>().Property(p => p.id).HasColumnName("idPessoa");
            //Define que uma coluna será obrigatória
            modelBuilder.Entity<Pessoa>().Property(p => p.id).IsRequired();

            modelBuilder.Entity<Pessoa>().HasKey(p => p.id);
        }
    }
}
