using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System;

namespace Projeto_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoRepository pessoaRepository = new AlunoRepository();

            Console.Write("Teste entity framework");

            var pessoas = pessoaRepository.GetAll();

            foreach (var p in pessoas)
                Console.WriteLine($"{p.Id} - {p.Nome} - {p.Idade}");

            Console.ReadKey();

            Console.WriteLine("\nCadastrar uma pessoa");

            Aluno pessoa = new Aluno();

            Console.Write("Nome:");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Idade:");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());

            pessoaRepository.Save(pessoa);

            pessoas = pessoaRepository.GetAll();

            foreach (var p in pessoas)
                Console.WriteLine($"{p.Id} - {p.Nome} - {p.Idade}");

            Console.ReadKey();
        }
    }
}