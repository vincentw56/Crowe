namespace Api
{
    using System;

    public class ConsoleWriter : BaseWriter
    {
        public override void GenerateMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}