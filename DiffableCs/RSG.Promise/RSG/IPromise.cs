namespace RSG;

public interface IPromise
{

	public int Id
	{
		 get { } //Length: 0
	}

	public IPromise Catch(Action<Exception> onRejected) { }

	public IPromise ContinueWith(Func<IPromise> onResolved) { }

	public IPromise<ConvertedT> ContinueWith(Func<IPromise`1<ConvertedT>> onComplete) { }

	public void Done(Action onResolved, Action<Exception> onRejected) { }

	public void Done(Action onResolved) { }

	public void Done() { }

	public IPromise Finally(Action onComplete) { }

	public int get_Id() { }

	public IPromise Progress(Action<Single> onProgress) { }

	public IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected) { }

	public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected) { }

	public IPromise Then(Func<IPromise> onResolved) { }

	public IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected, Action<Single> onProgress) { }

	public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public IPromise Then(Action onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved) { }

	public IPromise Then(Action onResolved) { }

	public IPromise Then(Action onResolved, Action<Exception> onRejected) { }

	public IPromise ThenAll(Func<IEnumerable`1<IPromise>> chain) { }

	public IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenRace(Func<IEnumerable`1<IPromise>> chain) { }

	public IPromise<ConvertedT> ThenRace(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenSequence(Func<IEnumerable`1<Func`1<IPromise>>> chain) { }

	public IPromise WithName(string name) { }

}

