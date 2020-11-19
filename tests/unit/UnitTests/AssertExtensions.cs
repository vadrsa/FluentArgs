using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    public static class AssertExtensions
	{
        public static void DoesNotThrowException<T>(Action expressionUnderTest, string exceptionMessage = "Expected exception was thrown by target of invocation.") where T : Exception
        {
            try
            {
                expressionUnderTest();
            }
            catch (T e)
            {
                Assert.Fail($"{exceptionMessage} {Environment.NewLine} Exception: {e}");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }

            Assert.IsTrue(true);
        }

        public static void DoesNotThrowException(Action expressionUnderTest, string exceptionMessage = "Expected exception was thrown by target of invocation.")
        {
            try
            {
                expressionUnderTest();
            }
            catch (Exception e)
            {
                Assert.Fail($"{exceptionMessage} {Environment.NewLine} Exception: {e}");
            }

            Assert.IsTrue(true);
        }
    }
}
