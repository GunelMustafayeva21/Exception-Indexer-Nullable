using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeTask.Models
{
    public class NotFoundException:Exception
    {
        //public NotFoundException() : base("Room is not founded") { }
        public NotFoundException(string message) : base(message) { }
    }
}
