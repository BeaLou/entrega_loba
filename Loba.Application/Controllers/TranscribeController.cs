using Loba.Domain.Dtos.Ata;
using Loba.Domain.Dtos.Transcribe;
using Loba.Domain.Dtos.UsuarioAudioTexto;
using Loba.Domain.Interfaces.Services.Ata;
using Loba.Domain.Interfaces.Services.UsuarioAudioTexto;
using Loba.Domain.Interfaces.Transcribe;
using Loba.Domain.Interfaces.Usuario;
using Loba.Service.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Net;
using System.Text;

namespace Loba.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranscribeController : ControllerBase
    {
        public ITranscribeService _transcribeService { get; set; }
        public IAtaService _ataService { get; set; }
        public IUsuarioService _usuarioService { get; set; }
        public IUsuarioAudioTextoService _usuarioAudioTextoService { get; set; }
        public SendEmailUtil _sendEmailUtil { get; set; }
        public PdfUtil _pdfUtil { get; set; }

        public TranscribeController(ITranscribeService transcribeService, IAtaService ataService, IUsuarioService usuarioService, IUsuarioAudioTextoService usuarioAudioTextoService, SendEmailUtil sendEmailUtil, PdfUtil pdfUtil)
        {
            _transcribeService = transcribeService;
            _ataService = ataService;
            _usuarioAudioTextoService = usuarioAudioTextoService;
            _usuarioService = usuarioService;
            _sendEmailUtil = sendEmailUtil;
            _pdfUtil = pdfUtil;

        }

        [HttpPost]
        public async Task<ActionResult> Post(TranscribeDtoCreateRequest transcribeDtoCreateRequest)
        {
            string email = "beatrizlourenco1912@gmail.com";

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                string idioma = "pt-BR";
                string pastaArquivoAudio = @"~/arquivoAudio/";
                System.IO.Directory.CreateDirectory(@"~/arquivoAudio/");
                string nomeArquivoAudio = "transcricao_" + Guid.NewGuid();
                string caminhoCompletoAudio = Path.Combine(pastaArquivoAudio, nomeArquivoAudio);
                var transcricao = this.AzureSpeech(caminhoCompletoAudio, idioma);

                string pastaArquivoTexto = @"~/arquivoTexto/";
                System.IO.Directory.CreateDirectory(@"~/arquivoTexto/");
                string nomeArquivoTexto = "ata_" + Guid.NewGuid();
                string caminhoCompletoTexto = Path.Combine(pastaArquivoTexto, nomeArquivoTexto + ".pdf");

                TranscribeDtoCreateRequest transcribeDto = new TranscribeDtoCreateRequest()
                {
                    nome = nomeArquivoAudio,
                    caminho = caminhoCompletoAudio,
                    duracao = "100"
                };

                var transcribeResponse = await _transcribeService.Post(transcribeDto);

                AtaDtoCreateRequest ataDto = new AtaDtoCreateRequest()
                {
                    nome = nomeArquivoTexto,
                    caminho = caminhoCompletoTexto,
                    tamanho = "100",
                    textoTranscricao = transcribeDtoCreateRequest.transcricao

                };

                var ataResponse = await _ataService.Post(ataDto);

                UsuarioAudioTextoDtoCreateRequest usuarioAudioTextoDto = new UsuarioAudioTextoDtoCreateRequest()
                {
                    idUsuario = -1,
                    idArquivoAudio = transcribeResponse.id,
                    idArquivoTexto = ataResponse.id,
                };

                var usuarioAudioTextoResponse = await _usuarioAudioTextoService.Post(usuarioAudioTextoDto);

                if (transcribeDtoCreateRequest.arquivoTranscricao != null && transcribeDtoCreateRequest.arquivoTranscricao.Length > 0)
                {
                    using (var streamReader = new StreamReader(transcribeDtoCreateRequest.arquivoTranscricao.OpenReadStream(), Encoding.UTF8))
                    {
                        string contentAsString =  await streamReader.ReadToEndAsync();
                    }                    
                }

                _pdfUtil.CriarPDF(transcribeDtoCreateRequest.transcricao, caminhoCompletoTexto);
                _sendEmailUtil.SendEmail(new Email() { to = email }, caminhoCompletoTexto);

                //retorno da API
                if (transcribeResponse != null)
                {
                    return Ok(await _transcribeService.Get(transcribeResponse.id));
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

        [HttpGet]
        [Route("bynome/{nome}", Name = "GetNome")]
        public async Task<ActionResult> GetNome(string nome)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _transcribeService.Get(nome);
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

        // GET api/<TranscribeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _transcribeService.Get(id);
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

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _transcribeService.GetAll();
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

        // PUT api/<TranscribeController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] TranscribeDtoUpdateRequest transcribeDtoUpdateRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _transcribeService.Put(transcribeDtoUpdateRequest);
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

        // DELETE api/<TranscribeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _transcribeService.Put(new TranscribeDtoUpdateRequest() { id = id, dataAlteracao = DateTime.Now, excluido = true }));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        private async Task<string> AzureSpeech(string filePath, string language)
        {
            string subscriptionKey = "2850619728124123b5c4c6f5e43b445c";
            string serviceRegion = "brazilsouth";

            var speechConfig = SpeechConfig.FromSubscription(subscriptionKey, serviceRegion);
            speechConfig.SpeechRecognitionLanguage = language;

            var audioConfig = AudioConfig.FromWavFileInput(filePath);
            using var speechRecognizer = new SpeechRecognizer(speechConfig, audioConfig);
            var speechRecognitionResult = await speechRecognizer.RecognizeOnceAsync();
            return speechRecognitionResult.Text;
        }

    }
}
