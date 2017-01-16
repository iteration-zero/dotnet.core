
namespace IterationZero.Core.Validation
{
    /// <summary>
    /// Handles the validation of method arguments.
    /// </summary>
    public static class ArgumentValidator
    {
        /// <summary>
        /// Validates that the supplied <paramref name="instance" /> is not null.
        /// </summary>
        /// <param name="instance">
        /// The argument to validate.
        /// </param>
        /// <param name="argumentName">
        /// The name of the argument to validate.
        /// </param>
        public static void ValidateInstance(object instance, string argumentName)
        {
            if (instance == null)
            {
                ExceptionManager.ThrowArgumentNullException(argumentName);
            }
        }
    }
}