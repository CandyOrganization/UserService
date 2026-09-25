using CandyOrg.Result.Abstractions;

namespace Application.Errors;

public class UserIsExistsError(string email) : BaseError
{
    public override string Message { get; } = $"Пользователь {email} уже существует в системе";
}