namespace AnimalCompany;

public class ItemSellingMachineView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<IEnumerator> <>9__35_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <PlayBulbEffectCoroutine>b__35_0(IEnumerator enumerator) { }

	}

	[CompilerGenerated]
	private sealed class <PlayBulbEffectCoroutine>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ItemSellingMachineView <>4__this; //Field offset: 0x20
		public int bulbIndex; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <PlayBulbEffectCoroutine>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <PlayItemSellAnimationCoroutine>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ItemSellingMachineView <>4__this; //Field offset: 0x20
		public float closeDuration; //Field offset: 0x28
		public float lightDuration; //Field offset: 0x2C
		public float randomWaitTime; //Field offset: 0x30
		public float openDuration; //Field offset: 0x34
		private float <lightIntensity>5__2; //Field offset: 0x38
		private float <elapsedTime>5__3; //Field offset: 0x3C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <PlayItemSellAnimationCoroutine>d__37(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ShowValueTextCoroutine>d__40 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ItemSellingMachineView <>4__this; //Field offset: 0x20
		public int value; //Field offset: 0x28
		private string <valueText>5__2; //Field offset: 0x30
		private float <elapsedTime>5__3; //Field offset: 0x38
		private int <repeatIndex>5__4; //Field offset: 0x3C
		private int <repeatPrev>5__5; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 8
		}

		[DebuggerHidden]
		public <ShowValueTextCoroutine>d__40(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly int PROP_USE_BULB_EFFECT; //Field offset: 0x0
	private const float BULB_EFFECT_DURATION = 1.5; //Field offset: 0x0
	private const float DOOR_CLOSE_ANGLE = 0; //Field offset: 0x0
	private static readonly int PROP_BASE_COLOR; //Field offset: 0x4
	private static readonly int PROP_EMISSION_COLOR; //Field offset: 0x8
	private static readonly Single[] DOOR_OPEN_ANGLE; //Field offset: 0x10
	private static readonly Color EMISSION_COLOR_OVERHEATED; //Field offset: 0x18
	private Color[] _originalBaseColors; //Field offset: 0x20
	[SerializeField]
	private CollisionTrigger[] _itemTriggers; //Field offset: 0x28
	[SerializeField]
	private MeshRenderer[] _renderersExceptBulb; //Field offset: 0x30
	[SerializeField]
	private MeshRenderer _bulbRendererBase; //Field offset: 0x38
	[SerializeField]
	private MeshRenderer[] _bulbRenderers; //Field offset: 0x40
	[SerializeField]
	private Light[] _lights; //Field offset: 0x48
	[SerializeField]
	private RandomSFX _SFXbulb; //Field offset: 0x50
	[SerializeField]
	private RandomSFX _SFXdoorClose; //Field offset: 0x58
	[SerializeField]
	private RandomSFX _SFXdoorOpen; //Field offset: 0x60
	[SerializeField]
	private RandomSFX _SFXSell; //Field offset: 0x68
	[SerializeField]
	private Transform[] _doorTransforms; //Field offset: 0x70
	[SerializeField]
	private TextMeshPro[] _valueTexts; //Field offset: 0x78
	private IEnumerator[] _bulbEffectCoroutines; //Field offset: 0x80
	private WaitForSeconds _bulbEffectWait; //Field offset: 0x88
	private IEnumerator _itemSellAnimationCoroutine; //Field offset: 0x90
	private IEnumerator _showValueTextCoroutine; //Field offset: 0x98
	private WaitForSeconds _waitForHalfSeconds; //Field offset: 0xA0
	private WaitForSeconds _waitForOneSecond; //Field offset: 0xA8
	private WaitForSeconds _waitForFiveSeconds; //Field offset: 0xB0

	public bool isSellingInProgress
	{
		 get { } //Length: 16
	}

	private static ItemSellingMachineView() { }

	public ItemSellingMachineView() { }

	private void Awake() { }

	public bool get_isSellingInProgress() { }

	private int GetRandomValue(int min, int max, int prev) { }

	private string GetRepeatString(string str, int repeat) { }

	private void OnItemTrigger1Enter(Collider col) { }

	private void OnItemTrigger2Enter(Collider col) { }

	private void OnItemTrigger3Enter(Collider col) { }

	[IteratorStateMachine(typeof(<PlayBulbEffectCoroutine>d__35))]
	private IEnumerator PlayBulbEffectCoroutine(int bulbIndex) { }

	private void PlayerBulbEffect(int bulbIndex) { }

	public void PlayItemSellAnimation(float closeDuration = 0.3, float lightDuration = 2, float openDuration = 0.3, float randomWaitTime = 1.5) { }

	[IteratorStateMachine(typeof(<PlayItemSellAnimationCoroutine>d__37))]
	private IEnumerator PlayItemSellAnimationCoroutine(float closeDuration, float lightDuration, float openDuration, float randomWaitTime) { }

	public void PlayValueTextAnimation(int value) { }

	public void SetExplodedColor(bool isExploded) { }

	public void SetOverheatedColor(bool isOverheated) { }

	[IteratorStateMachine(typeof(<ShowValueTextCoroutine>d__40))]
	private IEnumerator ShowValueTextCoroutine(int value) { }

	public void StopValueTextAnimation() { }

}

