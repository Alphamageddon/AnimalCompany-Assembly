namespace SpatialSys.CommandLib;

public static class Commands
{

	public static Command ChooseRandom(int seed, Command[] commands) { }

	public static Command ChooseRandom(Command[] commands) { }

	public static Command Condition(string identifier, CommandCondition condition, Command trueCommand, Command falseCommand, bool silent = false) { }

	public static Command Condition(CommandCondition condition, Command trueCommand, Command falseCommand, bool silent = false) { }

	public static Command Coroutine(string identifier, CoroutineGenerator coroutine, bool silent = false) { }

	public static Command Coroutine(CoroutineGenerator coroutine, bool silent = false) { }

	public static Command Do(Action commandDelegate, bool silent = false) { }

	public static Command Do(string identifier, Action commandDelegate, bool silent = false) { }

	public static Command Parallel(Command[] commands) { }

	public static Command Parallel(string identifier, Command[] commands) { }

	public static Command Promise(IPromise promise, bool abortOnReject = false, bool silent = false) { }

	public static Command Promise(string identifier, IPromise promise, bool abortOnReject = false, bool silent = false) { }

	public static Command Promise(IPromise<T> promise, bool abortOnReject = false, bool silent = false) { }

	public static Command Promise(string identifier, IPromise<T> promise, bool abortOnReject = false, bool silent = false) { }

	public static Command Require(string identifier, CommandCondition condition, Command[] sequence) { }

	public static Command Require(CommandCondition condition, Command[] sequence) { }

	public static Command Sequence(Command[] commands) { }

	public static Command Sequence(string identifier, Command[] commands) { }

	private static Command SetCommandSilent(Command cmd, bool silent) { }

	public static TaskCommand Task(string identifier, TaskGenerator taskGenerator, bool silent = false, Command parentCommand = null) { }

	public static TaskCommand<T> Task(TaskGenerator<T> taskGenerator, bool silent = false, Command parentCommand = null) { }

	public static TaskCommand<T> Task(string identifier, TaskGenerator<T> taskGenerator, bool silent = false, Command parentCommand = null) { }

	public static TaskCommand Task(TaskGenerator taskGenerator, bool silent = false, Command parentCommand = null) { }

	public static Command WaitForFrames(string identifier, int frameCount, bool silent = false) { }

	public static Command WaitForFrames(int frameCount, bool silent = false) { }

	public static Command WaitForSeconds(string identifier, float duration, bool silent = false) { }

	public static Command WaitForSeconds(float duration, bool silent = false) { }

	public static Command WaitUntil(string identifier, CommandConditionEval commandDelegate, bool silent = false) { }

	public static Command WaitUntil(CommandConditionEval commandDelegate, bool silent = false) { }

}

