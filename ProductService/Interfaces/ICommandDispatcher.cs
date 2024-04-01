﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Interfaces
{
    interface ICommandDispatcher
    {
        Task Dispatch<TCommand>(TCommand command);
    }
}
