namespace RSG;

public class Promise : IPromise<PromisedT>, IPendingPromise<PromisedT>, IRejectable, IPromiseInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Promise<PromisedT> <>4__this; //Field offset: 0x0
		public Exception ex; //Field offset: 0x0

		public <>c__DisplayClass24_0() { }

		internal void <InvokeRejectHandlers>b__0(RejectHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Promise<PromisedT> <>4__this; //Field offset: 0x0
		public float progress; //Field offset: 0x0

		public <>c__DisplayClass26_0() { }

		internal void <InvokeProgressHandlers>b__0(ProgressHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Promise resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0

		public <>c__DisplayClass34_0() { }

		internal void <Catch>b__0(PromisedT _) { }

		internal void <Catch>b__1(Exception ex) { }

		internal void <Catch>b__2(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Promise<PromisedT> resultPromise; //Field offset: 0x0
		public Func<Exception, PromisedT> onRejected; //Field offset: 0x0

		public <>c__DisplayClass35_0() { }

		internal void <Catch>b__0(PromisedT v) { }

		internal void <Catch>b__1(Exception ex) { }

		internal void <Catch>b__2(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Func<PromisedT, IPromise`1<ConvertedT>> onResolved; //Field offset: 0x0
		public Promise<ConvertedT> resultPromise; //Field offset: 0x0
		public Func<Exception, IPromise`1<ConvertedT>> onRejected; //Field offset: 0x0
		public Action<Single> <>9__2; //Field offset: 0x0
		public Action<ConvertedT> <>9__3; //Field offset: 0x0
		public Action<Exception> <>9__4; //Field offset: 0x0
		public Action<ConvertedT> <>9__5; //Field offset: 0x0
		public Action<Exception> <>9__6; //Field offset: 0x0

		public <>c__DisplayClass42_0`1() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(float progress) { }

		internal void <Then>b__3(ConvertedT chainedValue) { }

		internal void <Then>b__4(Exception ex) { }

		internal void <Then>b__5(ConvertedT chainedValue) { }

		internal void <Then>b__6(Exception callbackEx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public Func<PromisedT, IPromise> onResolved; //Field offset: 0x0
		public Promise resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0
		public Action<Single> <>9__2; //Field offset: 0x0
		public Action <>9__3; //Field offset: 0x0
		public Action<Exception> <>9__4; //Field offset: 0x0

		public <>c__DisplayClass43_0() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(float progress) { }

		internal void <Then>b__3() { }

		internal void <Then>b__4(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Action<PromisedT> onResolved; //Field offset: 0x0
		public Promise resultPromise; //Field offset: 0x0
		public Action<Exception> onRejected; //Field offset: 0x0

		public <>c__DisplayClass44_0() { }

		internal void <Then>b__0(PromisedT v) { }

		internal void <Then>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Func<PromisedT, ConvertedT> transform; //Field offset: 0x0

		public <>c__DisplayClass45_0`1() { }

		internal IPromise<ConvertedT> <Then>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass48_0`1() { }

		internal IPromise<IEnumerable`1<ConvertedT>> <ThenAll>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise>> chain; //Field offset: 0x0

		public <>c__DisplayClass49_0() { }

		internal IPromise <ThenAll>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public Single[] progress; //Field offset: 0x0
		public Promise<IEnumerable`1<PromisedT>> resultPromise; //Field offset: 0x0
		public PromisedT[] results; //Field offset: 0x0
		public int remainingCount; //Field offset: 0x0
		public Action<Exception> <>9__3; //Field offset: 0x0

		public <>c__DisplayClass51_0() { }

		internal void <All>b__0(IPromise<PromisedT> promise, int index) { }

		internal void <All>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_1
	{
		public int index; //Field offset: 0x0
		public <>c__DisplayClass51_0<PromisedT> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass51_1() { }

		internal void <All>b__1(float v) { }

		internal void <All>b__2(PromisedT result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass52_0`1() { }

		internal IPromise<ConvertedT> <ThenRace>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Func<PromisedT, IEnumerable`1<IPromise>> chain; //Field offset: 0x0

		public <>c__DisplayClass53_0() { }

		internal IPromise <ThenRace>b__0(PromisedT value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Promise<PromisedT> resultPromise; //Field offset: 0x0
		public Single[] progress; //Field offset: 0x0
		public Action<PromisedT> <>9__2; //Field offset: 0x0
		public Action<Exception> <>9__3; //Field offset: 0x0

		public <>c__DisplayClass55_0() { }

		internal void <Race>b__0(IPromise<PromisedT> promise, int index) { }

		internal void <Race>b__2(PromisedT result) { }

		internal void <Race>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_1
	{
		public int index; //Field offset: 0x0
		public <>c__DisplayClass55_0<PromisedT> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass55_1() { }

		internal void <Race>b__1(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Promise<PromisedT> promise; //Field offset: 0x0
		public Action onComplete; //Field offset: 0x0

		public <>c__DisplayClass58_0() { }

		internal void <Finally>b__0(PromisedT x) { }

		internal void <Finally>b__1(Exception e) { }

		internal PromisedT <Finally>b__2(PromisedT v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public Promise promise; //Field offset: 0x0

		public <>c__DisplayClass59_0() { }

		internal void <ContinueWith>b__0(PromisedT x) { }

		internal void <ContinueWith>b__1(Exception e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Promise promise; //Field offset: 0x0

		public <>c__DisplayClass60_0`1() { }

		internal void <ContinueWith>b__0(PromisedT x) { }

		internal void <ContinueWith>b__1(Exception e) { }

	}

	private Exception rejectionException; //Field offset: 0x0
	private PromisedT resolveValue; //Field offset: 0x0
	private List<RejectHandler> rejectHandlers; //Field offset: 0x0
	private List<ProgressHandler> progressHandlers; //Field offset: 0x0
	private List<Action`1<PromisedT>> resolveCallbacks; //Field offset: 0x0
	private List<IRejectable> resolveRejectables; //Field offset: 0x0
	private readonly int id; //Field offset: 0x0
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private PromiseState <CurState>k__BackingField; //Field offset: 0x0

	public private PromiseState CurState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override int Id
	{
		 get { } //Length: 8
	}

	public private override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Promise`1() { }

	public Promise`1(Action<Action`1<PromisedT>, Action`1<Exception>> resolver) { }

	[CompilerGenerated]
	private void <Done>b__30_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__31_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__32_0(Exception ex) { }

	private void ActionHandlers(IRejectable resultPromise, Action<PromisedT> resolveHandler, Action<Exception> rejectHandler) { }

	private void AddProgressHandler(Action<Single> onProgress, IRejectable rejectable) { }

	private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) { }

	private void AddResolveHandler(Action<PromisedT> onResolved, IRejectable rejectable) { }

	public static IPromise<IEnumerable`1<PromisedT>> All(IEnumerable<IPromise`1<PromisedT>> promises) { }

	public static IPromise<IEnumerable`1<PromisedT>> All(IPromise<PromisedT>[] promises) { }

	public override IPromise Catch(Action<Exception> onRejected) { }

	public override IPromise<PromisedT> Catch(Func<Exception, PromisedT> onRejected) { }

	private void ClearHandlers() { }

	public override IPromise<ConvertedT> ContinueWith(Func<IPromise`1<ConvertedT>> onComplete) { }

	public override IPromise ContinueWith(Func<IPromise> onComplete) { }

	public override void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public override void Done() { }

	public override void Done(Action<PromisedT> onResolved) { }

	public override IPromise<PromisedT> Finally(Action onComplete) { }

	[CompilerGenerated]
	public PromiseState get_CurState() { }

	public override int get_Id() { }

	[CompilerGenerated]
	public override string get_Name() { }

	private void InvokeHandler(Action<T> callback, IRejectable rejectable, T value) { }

	private void InvokeProgressHandlers(float progress) { }

	private void InvokeRejectHandlers(Exception ex) { }

	private void InvokeResolveHandlers(PromisedT value) { }

	public override IPromise<PromisedT> Progress(Action<Single> onProgress) { }

	private void ProgressHandlers(IRejectable resultPromise, Action<Single> progressHandler) { }

	public static IPromise<PromisedT> Race(IEnumerable<IPromise`1<PromisedT>> promises) { }

	public static IPromise<PromisedT> Race(IPromise<PromisedT>[] promises) { }

	public override void Reject(Exception ex) { }

	public static IPromise<PromisedT> Rejected(Exception ex) { }

	public override void ReportProgress(float progress) { }

	public override void Resolve(PromisedT value) { }

	public static IPromise<PromisedT> Resolved(PromisedT promisedValue) { }

	[CompilerGenerated]
	private void set_CurState(PromiseState value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public override IPromise Then(Action<PromisedT> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, ConvertedT> transform) { }

	public override IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public override IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected, Action<Single> onProgress) { }

	public override IPromise Then(Action<PromisedT> onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected) { }

	public override IPromise Then(Func<PromisedT, IPromise> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<PromisedT, IPromise`1<ConvertedT>> onResolved) { }

	public override IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenAll(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public override IPromise<ConvertedT> ThenRace(Func<PromisedT, IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenRace(Func<PromisedT, IEnumerable`1<IPromise>> chain) { }

	public override IPromise<PromisedT> WithName(string name) { }

}

