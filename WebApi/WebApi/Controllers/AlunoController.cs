using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

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
        [HttpGet]
        [ResponseType(typeof(IEnumerable<Aluno>))]
        public IEnumerable<Aluno> Get() 
        {
            var alunos = alunoRepository.GetAll();
            int cont = 0;

            foreach (var a in alunos)
                cont++;

            return alunos;
        }

        // GET: api/Aluno/5
        [HttpGet]
        [ResponseType(typeof(Aluno))]
        public Aluno GetById(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            return aluno != null ? aluno : null;
        }

        // POST: api/Aluno
        [HttpPost]
        [ResponseType(typeof(bool))]
        public void Post([FromBody]Aluno value)
        {
            if (value != null)
            {
                alunoRepository.Save(value);
            }
        }

        // PUT: api/Aluno/5
        [HttpPut]
        [ResponseType(typeof(bool))]
        public void Put(int id, [FromBody]Aluno value)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != null)
            {
                alunoRepository.Detached(aluno);
                alunoRepository.Update(value);
            }
        }

        // DELETE: api/Aluno/5
        [HttpDelete]
        [ResponseType(typeof(bool))]
        public void Delete(int id)
        {
            var aluno = alunoRepository.GetAll().FirstOrDefault(f => f.alunoId == id);

            if (aluno != null)
                //Delete com linq
                alunoRepository.Delete(x => x.alunoId == id);
        }
    }
}