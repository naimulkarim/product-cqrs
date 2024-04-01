using ProductService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Models
{
    public class CreateProduct : Product, ICommand
    {
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
