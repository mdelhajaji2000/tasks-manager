using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Helper.Exceptions
{
    internal class DbAccessException : Exception
    {
        public DbAccessException(string message, Exception inner) : base(message, inner) { }
    }
}
