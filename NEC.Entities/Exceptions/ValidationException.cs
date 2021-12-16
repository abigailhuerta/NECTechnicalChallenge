using NEC.Entities.Interface.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Entities.Exceptions
{
    public class ValidationException : Exception
    {
        public IEnumerable<IFailure> Failures { get; }

        public ValidationException() { }
        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, Exception innerExeption) : base(message, innerExeption) { }
        public ValidationException(IEnumerable<IFailure> failures)
        {
            Failures = failures;
        }
    }
}
