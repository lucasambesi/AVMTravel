using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdClientRequest, GetByIdClientResult>
    {
        private readonly IClientService _clientService;

        private readonly IMapper _mapper;

        public GetByIdHandler(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<GetByIdClientResult> Handle(
            GetByIdClientRequest request,
            CancellationToken cancellationToken)
        {
            var client = await _clientService.GetByIdAsync(request.Id);

            if (client == null)
            {
                throw new Exception("Entity not found");
            }

            var result = _mapper.Map<GetByIdClientResult>(client);

            return result;
        }
    }
}
