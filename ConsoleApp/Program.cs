﻿namespace ConsoleApp
{
    using Api;

    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            writer.GenerateMessage();
        }
    }
}