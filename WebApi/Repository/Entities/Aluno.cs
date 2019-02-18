using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    //Define o nome da tabela
    //[Table("Pessoas")]
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

        public static void Map(DbModelBuilder modelBuilder)
        {
            //Outra forma de definir o nome da tabela
            modelBuilder.Entity<Aluno>().ToTable("Pessoas");

            //Define um nome persinalizado para uma coluna
            modelBuilder.Entity<Aluno>().Property(p => p.id).HasColumnName("idPessoa");
            //Define que uma coluna será obrigatória
            modelBuilder.Entity<Aluno>().Property(p => p.id).IsRequired();

            modelBuilder.Entity<Aluno>().HasKey(p => p.id);
        }
    }
}
