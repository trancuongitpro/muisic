using System;

namespace Exercise_2
{
    public class AmountException : Exception, Exception
    {
        private string _personName;
        private string _message;

        public AmountException(string message, string personName) : base(message)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"Error: {message}, Name {personName}");
        }
    }
}