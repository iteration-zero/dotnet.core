using System;

using Xunit;

using IterationZero.Core;

namespace IterationZero.Core.Tests.Unit.ExceptionManagerTests
{
    /// <summary>
    /// Unit tests for the ThrowArgumentNullException method of the <see cref="ExceptionManager" /> class.
    /// </summary>
    public class ThrowArgumentNullExceptionTest
    {
        /// <summary>
        /// Tests that passing a null argumentName argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        public void NullArgumentNameShouldThrowException()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() =>
                ExceptionManager.ThrowArgumentNullException("someArgument")
            );
        
            Assert.True(exception.Message.Contains("Argument 'someArgument' is required."));
        }

        /// <summary>
        /// Tests that the default argument name is used if one is not supplied.
        /// </summary>
        [Fact]
        public void DefaultArgumentNameShouldBeUsed()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() =>
                        ExceptionManager.ThrowArgumentNullException(null)
            );

            Assert.True(exception.Message.Contains("Argument 'undefined' is required."));
        }
    }
}   