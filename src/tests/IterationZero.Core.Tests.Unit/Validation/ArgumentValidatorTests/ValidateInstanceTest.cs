using System;

using Xunit;

using IterationZero.Core.Validation;

namespace IterationZero.Core.Tests.Unit.Validation.ArgumentValidatorTests
{
    /// <summary>
    /// Unit tests for the ValidateInstance method of the <see cref="ArgumentValidator"/> class.
    /// </summary>
    public class ValidateInstanceTest
    {
        /// <summary>
        /// Tests the supplying a valid instance will result in
        /// no exception being thrown.
        /// </summary>
        [Fact]
        public void ValidInstanceShouldNotThrowException()
        {
            string message = string.Empty;

            try
            {
                ArgumentValidator.ValidateInstance(0, "test");
            }
            catch (ArgumentNullException ex)
            {

                message = ex.ParamName;
            }

            Assert.Equal<string>(string.Empty, message);
        }

        /// <summary>
        /// Tests that passing a null argument will result in an
        /// <see cref="ArgumentNullException"/> being thrown.
        /// </summary>
        [Fact]
        public void NullArgumentShouldThrowException()
        {
            string message = string.Empty;

            try
            {
                ArgumentValidator.ValidateInstance(null, "test");
            }
            catch (ArgumentNullException ex)
            {

                message = ex.ParamName;
            }

            Assert.Equal<string>("test", message);

        }
    }
}