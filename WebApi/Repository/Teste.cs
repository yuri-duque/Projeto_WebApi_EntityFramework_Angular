using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Teste
    {
        static void Main(string[] args)
        {
            AlunoRepository alunoRepository = new AlunoRepository();

            Console.WriteLine("Teste entity framework");

            var alunos = alunoRepository.GetAll();

            foreach (var a in alunos)
                Console.WriteLine($"{a.Id} - {a.Nome} - {a.Idade} - {a.Cpf}");

            Console.ReadKey();

            Console.WriteLine("\nCadastrar uma pessoa");

            Aluno aluno = new Aluno();

            Console.Write("Nome:");
            aluno.Nome = Console.ReadLine();

            Console.Write("Idade:");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("CPF:");
            aluno.Cpf = Console.ReadLine();

            alunoRepository.Save(aluno);

            alunos = alunoRepository.GetAll();

            foreach (var a in alunos)
                Console.WriteLine($"{a.Id} - {a.Nome} - {a.Idade} - {a.Cpf}");

            Console.ReadKey();
        }
    }
}
