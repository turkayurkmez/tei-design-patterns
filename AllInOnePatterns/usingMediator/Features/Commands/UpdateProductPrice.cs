using MediatR;

namespace usingMediator.Features.Commands
{
    public record UpdateProductPriceCommand(int ProductId, decimal NewPrice) : IRequest;

    public class UpdateProductPriceCommandHandler : IRequestHandler<UpdateProductPriceCommand>
    {
        public Task Handle(UpdateProductPriceCommand request, CancellationToken cancellationToken)
        {
             return Task.CompletedTask;
        }
    }
}
