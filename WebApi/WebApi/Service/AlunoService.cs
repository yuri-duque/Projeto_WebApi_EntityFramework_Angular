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

        public bool SalvarAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                alunoRepository.Save(aluno);
            }

            return true;
        }

        public string AlterarAluno(int id, Aluno value)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != null)
            {
                alunoRepository.Detached(aluno);
                alunoRepository.Update(value);
            }
            else
                return "Aluno não existe!";

            aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno == value)
                return "Salvo!";
            else
                return "Erro ao alterar valores!";
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