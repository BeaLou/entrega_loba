using Loba.Domain.Dtos.Ata;
using Loba.Domain.Interfaces.Services.Ata;
using Loba.Domain.Interfaces.Services.UsuarioAudioTexto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Loba.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtaController : ControllerBase
    {
        public IAtaService _ataService { get; set; }
        public IUsuarioAudioTextoService _usuarioAudioTextoService { get; set; }

        public AtaController(IAtaService ataService, IUsuarioAudioTextoService usuarioAudioTextoService)
        {
            _ataService = ataService;
            _usuarioAudioTextoService = usuarioAudioTextoService;
        }
        // GET: api/<AtaController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _ataService.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // GET api/<AtaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _ataService.Get(id);
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // POST api/<AtaController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AtaDtoCreateRequest ataDtoCreateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _ataService.Post(ataDtoCreateRequest);
                if (result != null)
                {
                    return Ok(await _ataService.Get(result.id));
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // PUT api/<AtaController>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] AtaDtoUpdateRequest ataDtoUpdateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _ataService.Put(ataDtoUpdateRequest);
                if (result == null)
                {
                    return BadRequest();
                }

                return Ok(result);

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        // DELETE api/<AtaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _ataService.Put(new AtaDtoUpdateRequest() { id = id, dataAlteracao = DateTime.Now, excluido = true }));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
