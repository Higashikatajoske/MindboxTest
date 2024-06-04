using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Exceptions
{
    public class TriangeCreateException: Exception
    {
        public TriangeCreateException(): base() 
        { 

        }

        public TriangeCreateException(string message) : base(message)
        {

        }

    }
}
