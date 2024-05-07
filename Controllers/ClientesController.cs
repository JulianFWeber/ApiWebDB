using ApiWebDB.BaseDados.Models;
using ApiWebDB.Services;
using ApiWebDB.Services.DTOs;
using ApiWebDB.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiWebDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _service;
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ClienteService service, ILogger<ClientesController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpPost()]
        public ActionResult<TbCliente> Insert(ClienteDTO cliente)
        {
            try
            {
                var entity = _service.Insert(cliente);
                return Ok(entity);
            }
            catch (InvalidEntityExceptions E)
            {
                return new ObjectResult(new { error = E.Message })
                {
                    StatusCode = 422
                };
            }
            catch (System.Exception E)
            {
                return BadRequest(E.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<TbCliente> Update(int id, ClienteDTO dto)
        {
            try
            {
                var entity = _service.Update(dto, id);
                return Ok(entity);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<TbCliente> Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch (NotFoundException E)
            {
                return NotFound(E.Message);
            }
            catch (System.Exception e)
            {
                return new ObjectResult(new { error = e.Message })
                {
                    StatusCode = 500
                };
            }
        }
        [HttpGet("{id}")]
        public ActionResult<TbCliente> GetById(int id)
        {
            try
            {
                var entity = _service.GetById(id);
                return Ok(entity);
            }
            catch (NotFoundException E)
            {
                return NotFound(E.Message);
            }
            catch (System.Exception e)
            { 
                _logger.LogError(e.Message);
                return new ObjectResult(new { error = e.Message })
                {
                    StatusCode = 500
                };
            }
        }
        [HttpGet()]
        public ActionResult<TbCliente> Get()
        {
            try
            {
                var entity = _service.Get();
                return Ok(entity);
            }
            catch (NotFoundException E)
            {
                return NotFound(E.Message);
            }
            catch (System.Exception e)
            {
                return new ObjectResult(new { error = e.Message })
                {
                    StatusCode = 500
                };
            }
        }
    }
}