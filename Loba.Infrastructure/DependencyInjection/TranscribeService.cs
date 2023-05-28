using AutoMapper;
using Loba.Domain.Dtos.Transcribe;
using Loba.Domain.Entities;
using Loba.Domain.Interfaces;
using Loba.Domain.Interfaces.Transcribe;
using Loba.Domain.Models;
using Loba.Domain.Repository;

namespace Loba.Infrastructure.DependencyInjection
{
    public class TranscribeService : ITranscribeService
    {
        private ITranscribeRepository _transcribeRepository;
        private readonly IMapper _mapper;

        public TranscribeService(ITranscribeRepository transcribeRepository, IMapper mapper)
        {
            _transcribeRepository = transcribeRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _transcribeRepository.DeleteAsync(id);
        }

        public async Task<TranscribeDto> Get(int id)
        {
            var entity = await _transcribeRepository.SelectAsync(id);
            return _mapper.Map<TranscribeDto>(entity);
        }
        public async Task<TranscribeDto> Get(string nome)
        {
            var entity = await _transcribeRepository.SelectAsync(nome);
            return _mapper.Map<TranscribeDto>(entity);
        }

        public async Task<IEnumerable<TranscribeDto>> GetAll()
        {
            var listEntity = await _transcribeRepository.SelectAsync();
            return _mapper.Map<IEnumerable<TranscribeDto>>(listEntity);
        }

        public async Task<TranscribeDto> Post(TranscribeDtoCreateRequest Transcribe)
        {
            var model = _mapper.Map<TranscribeModel>(Transcribe);
            var entity = _mapper.Map<TranscribeEntity>(model);
            var result = await _transcribeRepository.InsertAsync(entity);

            return _mapper.Map<TranscribeDto>(result);
        }

        public async Task<TranscribeDto> Put(TranscribeDtoUpdateRequest Transcribe)
        {
            var model = _mapper.Map<TranscribeModel>(Transcribe);
            var entity = _mapper.Map<TranscribeEntity>(model);
            var result = await _transcribeRepository.UpdateAsync(entity);

            return _mapper.Map<TranscribeDto>(result);
        }

    }
}