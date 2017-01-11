using System;
using System.Globalization;

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
        /// The name of the argument that was null.
        /// </param>
        public static void ThrowArgumentNullException(string argumentName)
        {
            // string currentArgumentName = argumentName;

			// if (string.IsNullOrEmpty(currentArgumentName)) {
			// 	//currentArgumentName = ExceptionManagerResource.UndefinedArgumentName;
            //     currentArgumentName = "undefined";
			// }

			// //string message = string.Format(CultureInfo.CurrentCulture, ExceptionManagerResource.ArgumentNullMessage, currentArgumentName);
            // string message = $"Argument '{ currentArgumentName }' is required.";
			// throw new ArgumentNullException(argumentName, message);
        }

        #endregion
    }
}