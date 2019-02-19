using Repository.Entities;
using Repository.Repository.RepositoryEntities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {
        private AlunoRepository db;

        public AlunoController()
        {
            this.db = new AlunoRepository();
        }

        //GET: api/Aluno
        public IEnumerable<Aluno> Get()
        {
            var teste = db.GetAll();
            int cont = 0;

            foreach (var t in teste)
                cont++;

            return teste;
        }

        // GET: api/Aluno/5
        public Aluno GetById(int id)
        {
            var aluno = db.GetAll().FirstOrDefault(f => f.Id == id);

            return aluno != null ? aluno : null;
        }

        // POST: api/Aluno
        public void Post([FromBody]Aluno value)
        {
            if (value != null)
            {
                db.Save(value);
            }
        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]Aluno value)
        {
            var aluno = db.GetAll().FirstOrDefault(f => f.Id == id);

            if (aluno != null)
            {
                db.Update(value);
            }
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
            var aluno = db.GetAll().FirstOrDefault(f => f.Id == id);

            if (aluno != null)
                //Delete com linq
                db.Delete(x => x.Id == id);
        }
    }
}