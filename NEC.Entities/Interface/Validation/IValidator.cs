using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Entities.Interface.Validation
{
    public interface IValidator<T>
    {
        IRule<T> AddRuleFor<TProperty>(
            Expression<Func<T, TProperty>> expression, bool StopOnFirstFailure);

        // AddRuleFor(Product => Product.Name)
        bool Validate(T instance);

        List<IFailure> Failures { get; }

        List<IFailure> SetValidatorFor<ItemTypes>
            (IEnumerable<ItemTypes> items, IValidator<ItemTypes> validator);

        IValidationService<T> ServiceValidator { get; }
    }
}
