namespace RSG;

public interface IPromiseTimer
{

	public bool Cancel(IPromise promise) { }

	public void Update(float deltaTime) { }

	public IPromise WaitFor(float seconds) { }

	public IPromise WaitUntil(Func<TimeData, Boolean> predicate) { }

	public IPromise WaitWhile(Func<TimeData, Boolean> predicate) { }

}

