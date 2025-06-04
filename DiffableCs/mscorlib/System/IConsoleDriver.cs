namespace System;

internal interface IConsoleDriver
{

	public ConsoleColor ForegroundColor
	{
		 set { } //Length: 0
	}

	public ConsoleKeyInfo ReadKey(bool intercept) { }

	public void ResetColor() { }

	public void set_ForegroundColor(ConsoleColor value) { }

}

