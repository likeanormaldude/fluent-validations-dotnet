using FluentValidation.Results;
using FluentValidationsOnDotnet.Model;

namespace FluentValidationsOnDotnet.Extensions;

public static class FluentValidationExtension
{
    public static IEnumerable<GroupedValidationFailure> ToGroupedValidationErrors(
        this IEnumerable<ValidationFailure> errors
    ) => errors.GroupBy(e => e.PropertyName).Select(ToGroupedValidationError);

    public static GroupedValidationFailure ToGroupedValidationError(
        IGrouping<string, ValidationFailure> groupedValidationFailure
    )
    {
        return new GroupedValidationFailure
        {
            PropertyName = groupedValidationFailure.Key,
            ErrorMessages = groupedValidationFailure.Select(x => x.ErrorMessage).ToList(),
        };
    }
}
