namespace AnimalCompany;

public class UnexpectedStateException : Exception
{

	public UnexpectedStateException() { }

	public UnexpectedStateException(string message) { }

	public UnexpectedStateException(string message, Exception inner) { }

}

