﻿using MediatR;
using Sm.Crm.Domain.Repositories;

namespace Sm.Crm.Application.Features.DocumentTypes.Commands.DeleteDocumentType;
public record DeleteDocumentTypeCommand(int Id) : IRequest<bool>;

public class DeleteDocumentTypeCommandHandler : IRequestHandler<DeleteDocumentTypeCommand, bool>
{
    private readonly IDocumentTypeRepository _repository;

    public DeleteDocumentTypeCommandHandler(IDocumentTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteDocumentTypeCommand request, CancellationToken cancellationToken)
    {
        bool isSuccess = await _repository.DeleteById(request.Id);
        return isSuccess;
    }
}