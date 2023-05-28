using Loba.Domain.Dtos.Transcribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Domain.Interfaces.Transcribe
{
    public interface ITranscribeService
    {
        Task<TranscribeDto> Get(int id);
        Task<IEnumerable<TranscribeDto>> GetAll();
        Task<TranscribeDto> Post(TranscribeDtoCreateRequest transcribeDtoCreateRequest);
        Task<TranscribeDto> Put(TranscribeDtoUpdateRequest transcribeDtoUpdateRequest);
        Task<bool> Delete(int id);

        Task<TranscribeDto> Get(string nome);
    }
}
