using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Delete
{
    public class DeleteHandler : IRequestHandler<DeleteTourRequest, DeleteTourResult>
    {
        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        public DeleteHandler(
            ITourService tourService,
            IMapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }

        public async Task<DeleteTourResult> Handle(
            DeleteTourRequest request, 
            CancellationToken cancellationToken)
        {
            var deleted = await _tourService.DeleteAsync(request.Id);

            var result = _mapper.Map<DeleteTourResult>(deleted);

            return result;
        }
    }
}
