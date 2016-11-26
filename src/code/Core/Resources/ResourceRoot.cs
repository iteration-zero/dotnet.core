using System;

namespace IterationZero.Core.Resources
{
    /// <summary>
    /// Represents the root of the resource hierarchy.
    /// </summary>
    public class ResourceRoot
    {
        /// <summary>
        /// Gets the resources for the <see cref="ExceptionManager"/> class.
        /// </summary>
        public virtual ExceptionManagerResource ExceptionManagerResource =>
            _exceptionManagerResource ?? (_exceptionManagerResource = new ExceptionManagerResource());

        private ExceptionManagerResource _exceptionManagerResource;
    }
}