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
        [TestInitialize]
        public void TestInitialize()
        {
            //ConfigurationManager.AppSettings.Clear();
        }

        [TestMethod]
        public void AnErrorShouldBeThrownWhenThereIsNoConfiguration()
        {
            IWriter writer = new Writer();

            Assert.ThrowsException<ConfigurationErrorsException>(() => { writer.GenerateMessage(); });
        }

        [TestMethod]
        public void ConsoleOutputShouldReturnCorrectMessage()
        {
            ConfigurationManager.AppSettings["writerOutput"] = "console";

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                IWriter writer = new Writer();
                writer.GenerateMessage();

                Assert.AreEqual<string>($"Hello World{Environment.NewLine}", stringWriter.ToString());
            }
        }

        [TestMethod]
        public void AnErrorShouldBeThrownWhenUsingUnimplementedOutputs()
        {
            ConfigurationManager.AppSettings["writerOutput"] = "dbase";

            IWriter writer = new Writer();

            Assert.ThrowsException<NotImplementedException>(() => { writer.GenerateMessage(); });
        }
    }
}