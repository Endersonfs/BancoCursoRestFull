using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public List<string> Errors { get;}

        public ValidationExceptions() :base("Se han producido uno o mas errores de validacion")
        {
            Errors = new List<string> ();
        }
        public ValidationExceptions(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures) 
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
