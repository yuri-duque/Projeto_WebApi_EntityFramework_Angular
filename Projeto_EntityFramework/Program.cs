using Projeto_EntityFramework.Entities;
using Projeto_EntityFramework.Repository.RepositoryEntities;
using System;

namespace Projeto_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaRepository pessoaRepository = new PessoaRepository();

            Console.Write("Teste entity framework"); 

            var pessoas = pessoaRepository.GetAll();

            foreach (var p in pessoas)
                Console.WriteLine($"{p.id} - {p.nome} - {p.idade}");

            Console.ReadKey();

            Console.WriteLine("\nCadastrar uma pessoa");

            Pessoa pessoa = new Pessoa();

            Console.Write("Nome:");
            pessoa.nome = Console.ReadLine();

            Console.Write("Idade:");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            pessoaRepository.Save(pessoa);

            pessoas = pessoaRepository.GetAll();

            foreach (var p in pessoas)
                Console.WriteLine($"{p.id} - {p.nome} - {p.idade}");

            Console.ReadKey();
        }
    }
}
