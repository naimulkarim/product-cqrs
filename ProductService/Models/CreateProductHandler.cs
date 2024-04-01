using ProductService.Interfaces;

namespace ProductService.Models
{
    public class CreateProductHandler : ICommandHandler<CreateProduct>
    {  
        public Task Handle(CreateProduct command)
        {
            Console.WriteLine(command.Name);
            return Task.CompletedTask;
        }
    }
}
