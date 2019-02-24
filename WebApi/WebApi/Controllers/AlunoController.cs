using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]//Usado para aceitar requisições de outras urls
    [RoutePrefix("api/aluno")]
    public class AlunoController : ApiController
    {
        private AlunoRepository alunoRepository;

        public AlunoController()
        {
            this.alunoRepository = new AlunoRepository();
        }

        //GET: api/Aluno
        public IEnumerable<Aluno> Get()
        {
            var alunos = alunoRepository.GetAll();
            int cont = 0;

            foreach (var a in alunos)
                cont++;

            return alunos;
        }

        // GET: api/Aluno/5
        public Aluno GetById(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.AlunoId == id);

            return aluno != null ? aluno : null;
        }

        // POST: api/Aluno
        public void Post([FromBody]Aluno value)
        {
            if (value != null)
            {
                alunoRepository.Save(value);
            }
        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]Aluno value)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.AlunoId == id);

            if (aluno != null)
            {
                alunoRepository.Update(value);
            }
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.AlunoId == id);

            if (aluno != null)
                //Delete com linq
                alunoRepository.Delete(x => x.AlunoId == id);
        }
    }
}