using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Interfaces
{
    interface IQueryDispatcher<in TCommand, TResult> where TResult : ICommand
    {
        Task Dispatch(TCommand command);
    }
}
