using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        //O mapeamento também pode ser feito dessa forma
        [Key]
        [Required]
        [Column("IdAluno")]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Idade { get; set; }
        [Required]
        public string Cpf { get; set; }

        public static void Map(DbModelBuilder modelBuilder)
        {
            ////Outra forma de definir o nome da tabela
            //modelBuilder.Entity<Aluno>().ToTable("Alunos");

            ////Define um nome persinalizado para uma coluna
            //modelBuilder.Entity<Aluno>().Property(p => p.Id).HasColumnName("idAluno");

            ////Define que uma coluna será obrigatória
            //modelBuilder.Entity<Aluno>().Property(p => p.Id).IsRequired();

            //modelBuilder.Entity<Aluno>().HasKey(p => p.Id);
        }
    }
}
