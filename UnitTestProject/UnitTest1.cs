namespace UnitTestProject
{
    using System;
    using System.Configuration;
    using System.IO;

    using Api;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsoleOutputShouldReturnCorrectMessage()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                IWriter writer = new ConsoleWriter();
                writer.GenerateMessage();

                Assert.AreEqual<string>($"Hello World{Environment.NewLine}", stringWriter.ToString());
            }
        }

        [TestMethod]
        public void AnErrorShouldBeThrownWhenUsingDatabaseWriterBecauseItIsNotImpementedYet()
        {
            IWriter writer = new DatabaseWriter();

            Assert.ThrowsException<NotImplementedException>(() => { writer.GenerateMessage(); });
        }
    }
}