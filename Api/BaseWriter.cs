namespace Api
{
    using System;

    public abstract class BaseWriter : IWriter
    {
        public virtual void GenerateMessage()
        {
        }
    }
}