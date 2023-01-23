using System;
namespace Execptions
{
	public class UncorrectInputException : Exception
	{
		public UncorrectInputException() { }

		public UncorrectInputException(string message) : base(message) { }

        public UncorrectInputException(string message, Exception inner) : base(message, inner) { }
	}
}

