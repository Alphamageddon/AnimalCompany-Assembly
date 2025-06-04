namespace RSG;

public class Promise : IPromise, IPendingPromise, IRejectable, IPromiseInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Promise <>4__this; //Field offset: 0x10
		public Exception ex; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal void <InvokeRejectHandlers>b__0(RejectHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Promise <>4__this; //Field offset: 0x10
		public float progress; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <InvokeProgressHandlers>b__0(ProgressHandler handler) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Promise resultPromise; //Field offset: 0x10
		public Action<Exception> onRejected; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal void <Catch>b__0() { }

		internal void <Catch>b__1(Exception ex) { }

		internal void <Catch>b__2(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public Func<IPromise`1<ConvertedT>> onResolved; //Field offset: 0x0
		public Promise<ConvertedT> resultPromise; //Field offset: 0x0
		public Func<Exception, IPromise`1<ConvertedT>> onRejected; //Field offset: 0x0
		public Action<Single> <>9__2; //Field offset: 0x0
		public Action<ConvertedT> <>9__3; //Field offset: 0x0
		public Action<Exception> <>9__4; //Field offset: 0x0
		public Action<ConvertedT> <>9__5; //Field offset: 0x0
		public Action<Exception> <>9__6; //Field offset: 0x0

		public <>c__DisplayClass51_0`1() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(float progress) { }

		internal void <Then>b__3(ConvertedT chainedValue) { }

		internal void <Then>b__4(Exception ex) { }

		internal void <Then>b__5(ConvertedT chainedValue) { }

		internal void <Then>b__6(Exception callbackEx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Func<IPromise> onResolved; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public Action<Exception> onRejected; //Field offset: 0x20
		public Action<Single> <>9__2; //Field offset: 0x28
		public Action <>9__3; //Field offset: 0x30
		public Action<Exception> <>9__4; //Field offset: 0x38

		public <>c__DisplayClass52_0() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

		internal void <Then>b__2(float progress) { }

		internal void <Then>b__3() { }

		internal void <Then>b__4(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Action onResolved; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public Action<Exception> onRejected; //Field offset: 0x20

		public <>c__DisplayClass53_0() { }

		internal void <Then>b__0() { }

		internal void <Then>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Func<IEnumerable`1<IPromise>> chain; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal IPromise <ThenAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass57_0`1() { }

		internal IPromise<IEnumerable`1<ConvertedT>> <ThenAll>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public Single[] progress; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public int remainingCount; //Field offset: 0x20
		public Action<Exception> <>9__3; //Field offset: 0x28

		public <>c__DisplayClass59_0() { }

		internal void <All>b__0(IPromise promise, int index) { }

		internal void <All>b__3(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_1
	{
		public int index; //Field offset: 0x10
		public <>c__DisplayClass59_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass59_1() { }

		internal void <All>b__1(float v) { }

		internal void <All>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public Func<IEnumerable`1<Func`1<IPromise>>> chain; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal IPromise <ThenSequence>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public int count; //Field offset: 0x10
		public Promise promise; //Field offset: 0x18

		public <>c__DisplayClass62_0() { }

		internal IPromise <Sequence>b__0(IPromise prevPromise, Func<IPromise> fn) { }

		internal void <Sequence>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_1
	{
		public int itemSequence; //Field offset: 0x10
		public Func<IPromise> fn; //Field offset: 0x18
		public <>c__DisplayClass62_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass62_1() { }

		internal IPromise <Sequence>b__2() { }

		internal void <Sequence>b__3(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public Func<IEnumerable`1<IPromise>> chain; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal IPromise <ThenRace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain; //Field offset: 0x0

		public <>c__DisplayClass64_0`1() { }

		internal IPromise<ConvertedT> <ThenRace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public Single[] progress; //Field offset: 0x10
		public Promise resultPromise; //Field offset: 0x18
		public Action<Exception> <>9__2; //Field offset: 0x20
		public Action <>9__3; //Field offset: 0x28

		public <>c__DisplayClass66_0() { }

		internal void <Race>b__0(IPromise promise, int index) { }

		internal void <Race>b__2(Exception ex) { }

		internal void <Race>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_1
	{
		public int index; //Field offset: 0x10
		public <>c__DisplayClass66_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass66_1() { }

		internal void <Race>b__1(float v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public Promise promise; //Field offset: 0x10
		public Action onComplete; //Field offset: 0x18

		public <>c__DisplayClass69_0() { }

		internal void <Finally>b__0() { }

		internal void <Finally>b__1(Exception e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public Promise promise; //Field offset: 0x10

		public <>c__DisplayClass70_0() { }

		internal void <ContinueWith>b__0() { }

		internal void <ContinueWith>b__1(Exception e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Promise promise; //Field offset: 0x0

		public <>c__DisplayClass71_0`1() { }

		internal void <ContinueWith>b__0() { }

		internal void <ContinueWith>b__1(Exception e) { }

	}

	internal struct ResolveHandler
	{
		public Action callback; //Field offset: 0x0
		public IRejectable rejectable; //Field offset: 0x8

	}

	public static bool EnablePromiseTracking; //Field offset: 0x0
	private static EventHandler<ExceptionEventArgs> unhandlerException; //Field offset: 0x8
	private static int nextPromiseId; //Field offset: 0x10
	internal static readonly HashSet<IPromiseInfo> PendingPromises; //Field offset: 0x18
	private Exception rejectionException; //Field offset: 0x10
	private List<RejectHandler> rejectHandlers; //Field offset: 0x18
	private List<ResolveHandler> resolveHandlers; //Field offset: 0x20
	private List<ProgressHandler> progressHandlers; //Field offset: 0x28
	private readonly int id; //Field offset: 0x30
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private PromiseState <CurState>k__BackingField; //Field offset: 0x40

	public static event EventHandler<ExceptionEventArgs> UnhandledException
	{
		 add { } //Length: 212
		 remove { } //Length: 212
	}

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

	private static Promise() { }

	public Promise(Action<Action, Action`1<Exception>> resolver) { }

	public Promise() { }

	[CompilerGenerated]
	private void <Done>b__40_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__41_0(Exception ex) { }

	[CompilerGenerated]
	private void <Done>b__42_0(Exception ex) { }

	[CompilerGenerated]
	private void <InvokeResolveHandlers>b__35_0(ResolveHandler handler) { }

	private void ActionHandlers(IRejectable resultPromise, Action resolveHandler, Action<Exception> rejectHandler) { }

	public static void add_UnhandledException(EventHandler<ExceptionEventArgs> value) { }

	private void AddProgressHandler(Action<Single> onProgress, IRejectable rejectable) { }

	private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) { }

	private void AddResolveHandler(Action onResolved, IRejectable rejectable) { }

	public static IPromise All(IEnumerable<IPromise> promises) { }

	public static IPromise All(IPromise[] promises) { }

	public override IPromise Catch(Action<Exception> onRejected) { }

	private void ClearHandlers() { }

	public override IPromise ContinueWith(Func<IPromise> onComplete) { }

	public override IPromise<ConvertedT> ContinueWith(Func<IPromise`1<ConvertedT>> onComplete) { }

	public override void Done() { }

	public override void Done(Action onResolved) { }

	public override void Done(Action onResolved, Action<Exception> onRejected) { }

	public override IPromise Finally(Action onComplete) { }

	[CompilerGenerated]
	public PromiseState get_CurState() { }

	public override int get_Id() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public static IEnumerable<IPromiseInfo> GetPendingPromises() { }

	private void InvokeProgressHandler(Action<Single> callback, IRejectable rejectable, float progress) { }

	private void InvokeProgressHandlers(float progress) { }

	private void InvokeRejectHandler(Action<Exception> callback, IRejectable rejectable, Exception value) { }

	private void InvokeRejectHandlers(Exception ex) { }

	private void InvokeResolveHandler(Action callback, IRejectable rejectable) { }

	private void InvokeResolveHandlers() { }

	internal static int NextId() { }

	public override IPromise Progress(Action<Single> onProgress) { }

	private void ProgressHandlers(IRejectable resultPromise, Action<Single> progressHandler) { }

	internal static void PropagateUnhandledException(object sender, Exception ex) { }

	public static IPromise Race(IPromise[] promises) { }

	public static IPromise Race(IEnumerable<IPromise> promises) { }

	public override void Reject(Exception ex) { }

	public static IPromise Rejected(Exception ex) { }

	public static void remove_UnhandledException(EventHandler<ExceptionEventArgs> value) { }

	public override void ReportProgress(float progress) { }

	public override void Resolve() { }

	public static IPromise Resolved() { }

	public static IPromise Sequence(IEnumerable<Func`1<IPromise>> fns) { }

	public static IPromise Sequence(Func<IPromise>[] fns) { }

	[CompilerGenerated]
	private void set_CurState(PromiseState value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	public override IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected, Action<Single> onProgress) { }

	public override IPromise Then(Action onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public override IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected, Action<Single> onProgress) { }

	public override IPromise Then(Action onResolved, Action<Exception> onRejected) { }

	public override IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected) { }

	public override IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved, Func<Exception, IPromise`1<ConvertedT>> onRejected) { }

	public override IPromise Then(Func<IPromise> onResolved) { }

	public override IPromise<ConvertedT> Then(Func<IPromise`1<ConvertedT>> onResolved) { }

	public override IPromise Then(Action onResolved) { }

	public override IPromise<IEnumerable`1<ConvertedT>> ThenAll(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenAll(Func<IEnumerable`1<IPromise>> chain) { }

	public override IPromise ThenRace(Func<IEnumerable`1<IPromise>> chain) { }

	public override IPromise<ConvertedT> ThenRace(Func<IEnumerable`1<IPromise`1<ConvertedT>>> chain) { }

	public override IPromise ThenSequence(Func<IEnumerable`1<Func`1<IPromise>>> chain) { }

	public override IPromise WithName(string name) { }

}

