using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Service
{
    public class AlunoService
    {
        private AlunoRepository alunoRepository;

        public AlunoService()
        {
            this.alunoRepository = new AlunoRepository();
        }

        public IEnumerable<Aluno> BuscarTodosAlunos()
        {
            var alunos = alunoRepository.GetAll();
            int cont = 0;

            foreach (var a in alunos)
                cont++;

            return alunos;
        }

        public Aluno BuscarAlunoPorId(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            //return aluno != null ? aluno : return ;
            if (aluno == null)
                return null;
            else
                return aluno;
        }

        public void SalvarAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                var value = alunoRepository.GetAll().FirstOrDefault(f => f.cpf == aluno.cpf);

                if (value == null)
                    alunoRepository.Save(aluno);
                else
                    throw new Exception("Já existe um aluno com esse cpf!");
            }
            else
                throw new Exception("Aluno está nulo!");
        }

        public void AlterarAluno(int id, Aluno value)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != null)
            {
                alunoRepository.Detached(aluno);
                alunoRepository.Update(value);
            }
            else
                throw new Exception("Aluno está nulo!");

            aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != value)
                throw new Exception("Erro ao alterar valores!");
        }

        public bool RemoverAluno(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != null)
                //Delete com linq
                alunoRepository.Delete(x => x.alunoId == id);

            aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno == null)
                return true;
            else
                return false;
        }
    }
}