using System;
using System.Globalization;

using IterationZero.Core.Resources;

namespace IterationZero.Core
{
    /// <summary>
    /// Handles the throwing of localized exceptions.
    /// </summary>
    public class ExceptionManager
    {
        #region : Public Methods :
            
        /// <summary>
        /// Throws a localized <see cref="ArgumentNullException"/>.
        /// </summary>
        /// <param name="argumentName">
        /// The name of the argument that was null.c
        /// </param>
        public static void ThrowArgumentNullException(string argumentName)
        {
            string currentArgumentName = argumentName;

			if (string.IsNullOrEmpty(currentArgumentName))
			{
			    currentArgumentName
			        = ResourceRegistry.Instance.GetCurrent().ExceptionManagerResource.DefaultArgumentName;
			}
            
            string message = $"Argument '{ currentArgumentName }' is required.";
			throw new ArgumentNullException(argumentName, message);
        }

        #endregion
    }
}