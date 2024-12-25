using MediatR;

namespace usingMediator.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, int>
    {
        //public int Handler(CreateProductCommandRequest request)
        //{
        //    return 0;
        //}
        public async Task<int> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
           return  await Task.FromResult(1);
        }
    }
}
