using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeTask.Models
{
    public class NotAvailableException:Exception
    {
        //public NotAvailableException() : base("It is already reserved") { }
        public NotAvailableException(string message) : base(message) { }
    }
}
