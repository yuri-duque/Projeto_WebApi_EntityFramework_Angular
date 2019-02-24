using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System;

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
                Console.WriteLine($"{a.alunoId} - {a.nome} - {a.idade} - {a.cpf}");

            bool denovo = false;

            Console.ReadKey();

            do
            {
                Console.WriteLine("\nCadastrar uma pessoa");

                Aluno aluno = new Aluno();

                Console.Write("Nome:");
                aluno.nome = Console.ReadLine();

                Console.Write("Idade:");
                aluno.idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("CPF:");
                aluno.cpf = Console.ReadLine();

                alunoRepository.Save(aluno);

                alunos = alunoRepository.GetAll();

                foreach (var a in alunos)
                    Console.WriteLine($"{a.alunoId} - {a.nome} - {a.idade} - {a.cpf}");

                Console.WriteLine("Inserir novo Aluno? (S/N)");
                denovo = Console.ReadLine().ToUpper().Equals("S") ? true : false;

            } while (denovo);

            Console.ReadKey();
        }
    }
}
