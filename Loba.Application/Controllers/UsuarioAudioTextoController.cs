using Loba.Domain.Dtos.UsuarioAudioTexto;
using Loba.Domain.Interfaces.Services.UsuarioAudioTexto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Loba.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioAudioTextoController : ControllerBase
    {
        public IUsuarioAudioTextoService _usuarioAudioTextoService { get; set; }

        public UsuarioAudioTextoController(IUsuarioAudioTextoService usuarioAudioTextoService)
        {
            _usuarioAudioTextoService = usuarioAudioTextoService;
        }
        // GET: api/<UsuarioAudioTextoController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _usuarioAudioTextoService.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // GET api/<UsuarioAudioTextoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _usuarioAudioTextoService.Get(id);
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

        // POST api/<UsuarioAudioTextoController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UsuarioAudioTextoDtoCreateRequest usuarioAudioTextoDtoCreateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _usuarioAudioTextoService.Post(usuarioAudioTextoDtoCreateRequest);
                if (result != null)
                {
                    return Ok(await _usuarioAudioTextoService.Get(result.id));
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

        // PUT api/<UsuarioAudioTextoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UsuarioAudioTextoDtoUpdateRequest usuarioAudioTextoDtoUpdateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _usuarioAudioTextoService.Put(usuarioAudioTextoDtoUpdateRequest);
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

        // DELETE api/<UsuarioAudioTextoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _usuarioAudioTextoService.Put(new UsuarioAudioTextoDtoUpdateRequest() { id = id, dataAlteracao = DateTime.Now, excluido = true }));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
