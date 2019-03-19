namespace Api
{
    using System;
    using System.Configuration;

    public class Writer : IWriter
    {
        public void GenerateMessage()
        {
            string writerOutput = ConfigurationManager.AppSettings["writerOutput"];

            switch (writerOutput)
            {
                case "console":
                    Console.WriteLine("Hello World");
                    break;

                case "dbase":
                case "webapi":
                    throw new NotImplementedException();

                default:
                    throw new ConfigurationErrorsException("Configuration for writer is missing or misconfigured");
            }
        }
    }
}