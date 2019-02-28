using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi.Service;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]//Usado para aceitar requisições de outras urls
    [RoutePrefix("api/aluno")]
    public class AlunoController : ApiController
    {
        private AlunoService alunoService;

        public AlunoController()
        {
            this.alunoService = new AlunoService();
        }

        //GET: api/Aluno
        [HttpGet]
        [ResponseType(typeof(IEnumerable<Aluno>))]
        //public IEnumerable<Aluno> Get()
        public IHttpActionResult Get()
        {
            try
            {
                var alunos = alunoService.BuscarTodosAlunos();

                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Aluno/5
        [HttpGet]
        [ResponseType(typeof(Aluno))]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var aluno = alunoService.BuscarAlunoPorId(id);

                if (aluno != null)
                    return Ok(aluno);
                else
                    return Content(System.Net.HttpStatusCode.NotFound, "Aluno não existe!");
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // POST: api/Aluno
        [HttpPost]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Post([FromBody]Aluno aluno)
        {
            try
            {
                bool salvo = alunoService.SalvarAluno(aluno);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // PUT: api/Aluno/5
        [HttpPut]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Put(int id, [FromBody]Aluno aluno)
        {
            try
            {
                var modificado = alunoService.AlterarAluno(id, aluno);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Aluno/5
        [HttpDelete]
        [ResponseType(typeof(bool))]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var removido = alunoService.RemoverAluno(id);

                if (removido)
                    return Ok();
                else
                    return Content(System.Net.HttpStatusCode.BadRequest, "Erro ao remover o aluno!");
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}