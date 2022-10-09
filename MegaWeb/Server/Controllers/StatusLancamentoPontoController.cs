using MegaWeb.Server.Services.Interfaces;
using MegaWeb.Shared.DTO.StatusDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MegaWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusLancamentoPontoController : Controller
    {
        private readonly IServiceStatusLancamentoPonto _service;

        public StatusLancamentoPontoController(IServiceStatusLancamentoPonto service)
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

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] StatusLancamentoPontoDto status)
        {
            try
            {
                if (status == null)
                    return NotFound();

                await _service.Add(status);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}