﻿using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler(IRepository<Feature> repository) : IRequestHandler<UpdateFeatureCommand>
    {
        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await repository.UpdateAsync(value);
        }
    }
}
