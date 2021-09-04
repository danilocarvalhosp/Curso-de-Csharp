using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Exceptions
{
    class AccountExceptions : ApplicationException
    {
        public AccountExceptions(string message) : base(message)
        {
        }
    }
}
