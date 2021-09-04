using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
