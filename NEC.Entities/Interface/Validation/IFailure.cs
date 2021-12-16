namespace NEC.Entities.Interface.Validation
{
    public interface IFailure
    {
        string PropertyName { get; }
        string ErrorMessage { get; }
    }
}