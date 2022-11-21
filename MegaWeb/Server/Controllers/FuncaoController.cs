using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.DTO.FuncaoDtos;
using MegaWeb.Shared.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MegaWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncaoController : ControllerBase
    {
        private readonly IServiceFuncao _service;

        public FuncaoController(IServiceFuncao service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}", Name = "GetWithIdFuncao")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                return Ok(await _service.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FuncaoRequest funcao)
        {
            try
            {
                if (funcao == null)
                    return NotFound();

                await _service.Add(funcao);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] FuncaoDtoUpdate funcao)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Update(funcao);

                if (result != null)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Remove(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}