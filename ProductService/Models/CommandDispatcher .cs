using Microsoft.Extensions.DependencyInjection;
using ProductService.Interfaces;


namespace ProductService.Models
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Task Dispatch<TCommand>(TCommand command)
        {

            var handler = this.serviceProvider.GetService<ICommandHandler<TCommand>>();
            return handler.Handle(command);
        }
    }
}
