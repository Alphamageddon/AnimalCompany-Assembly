namespace System;

internal class NullConsoleDriver : IConsoleDriver
{
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; //Field offset: 0x0

	public override ConsoleColor ForegroundColor
	{
		 set { } //Length: 4
	}

	private static NullConsoleDriver() { }

	public NullConsoleDriver() { }

	public override ConsoleKeyInfo ReadKey(bool intercept) { }

	public override void ResetColor() { }

	public override void set_ForegroundColor(ConsoleColor value) { }

}

