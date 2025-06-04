namespace RSG;

public interface IPromise
{

	public int Id
	{
		 get { } //Length: 0
	}

	public IPromise Catch(Action<Exception> onRejected) { }

	public IPromise<PromisedT> Catch(Func<Exception, PromisedT> onRejected) { }

	public IPromise ContinueWith(Func<IPromise> onResolved) { }

	public IPromise<ConvertedT> ContinueWith(Func<IPromise`1<ConvertedT>> onComplete) { }

	public void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public void Done(Action<PromisedT> onResolved) { }

	public void Done() { }

	public IPromise<PromisedT> Finally(Action onComplete) { }

	public int get_Id() { }

	public IPromise<PromisedT> Progress(Action<Single> onProgress) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected) { }

	public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected) { }

	public IPromise Then(Func<PromisedT, IPromise> onResolved) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected, Action<Single> onProgress) { }

	public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, ConvertedT> transform) { }

	public IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved) { }

	public IPromise Then(Action<PromisedT> onResolved) { }

	public IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenAll(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public IPromise<ConvertedT> ThenRace(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public IPromise ThenRace(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public IPromise<PromisedT> WithName(string name) { }

}

