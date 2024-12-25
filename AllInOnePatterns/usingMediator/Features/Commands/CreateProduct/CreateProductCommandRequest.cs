using MediatR;

namespace usingMediator.Features.Commands.CreateProduct
{
    public record CreateProductCommandRequest(string Name, decimal Price):IRequest<int>;


    
}
