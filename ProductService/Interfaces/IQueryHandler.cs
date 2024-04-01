using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Interfaces
{
    interface IQueryHandler<in TCommand, TResult> where TCommand : ICommand
    {
        Task<TResult> Handle(TCommand command);
    }
}
