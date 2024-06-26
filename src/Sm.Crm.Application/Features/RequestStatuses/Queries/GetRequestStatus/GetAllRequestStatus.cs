﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Sm.Crm.Domain.Repositories;

namespace Sm.Crm.Application.Features.RequestStatuses.Queries.GetRequestStatus;
public record GetAllRequestStatusQuery : IRequest<ICollection<RequestStatusDto>>;

public class GetAllRequestStatusQueryHandler : IRequestHandler<GetAllRequestStatusQuery, ICollection<RequestStatusDto>>
{
    private readonly IRequestStatusRepository _repository;
    private readonly IMapper _mapper;

    public GetAllRequestStatusQueryHandler(IRequestStatusRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ICollection<RequestStatusDto>> Handle(GetAllRequestStatusQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.GetAll().ToListAsync();
        return _mapper.Map<List<RequestStatusDto>>(entities);
    }
}