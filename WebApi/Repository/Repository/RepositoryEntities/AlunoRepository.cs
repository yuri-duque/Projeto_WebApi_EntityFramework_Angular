using Repository.Context;
using Repository.Entities;
using System;

namespace Repository.Repository.RepositoryEntities
{
    public class AlunoRepository : Repository<Aluno>
    {
        public void Dispose()
        {
            ctx.Dispose();
        }

        BaseContext ctx = new BaseContext();

        public override void Save(Aluno aluno)
        {
            aluno = ctx.Set<Aluno>().Find(aluno.Cpf) ?? ctx.Set<Aluno>().Find(aluno.Nome);

            if(aluno == null || aluno == new Aluno())
            {
                ctx.Set<Aluno>().Add(aluno);
                ctx.SaveChanges();
            }
            else
            {
                throw new Exception($"O Aluno {aluno.Nome ?? ""} já existe!");
            }
        }
    }
}
