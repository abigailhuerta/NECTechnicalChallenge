using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Entities.Interface.Validation
{
    public interface IRule<T>
    {
        IRule<T> AddRequirement(Expression<Func<T, bool>> requirement,
            string errorMessage);

        IRule<T> AddCollectionItemsValidator(Expression<Func<T, IEnumerable<IFailure>>> itemValidator);
    }
}
