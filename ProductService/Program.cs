using Microsoft.Extensions.DependencyInjection;
using ProductService.Interfaces;
using ProductService.Models;

namespace ProductService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CQRS without mediatr");

            var services = new ServiceCollection();
            services.AddSingleton<ICommandDispatcher, CommandDispatcher>();            
            services.AddSingleton<ICommandHandler<CreateProduct>, CreateProductHandler>();


            var createProduct = new CreateProduct();
            createProduct.Name = "Prod1";

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var dispatcher = serviceProvider.GetService<ICommandDispatcher>();
            dispatcher.Dispatch(createProduct);

        }
    }
  
}