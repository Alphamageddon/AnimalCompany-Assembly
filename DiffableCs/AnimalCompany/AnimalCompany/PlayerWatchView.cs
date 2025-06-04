namespace AnimalCompany;

public class PlayerWatchView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SetMoneyTextAnimationCoroutine>d__45 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerWatchView <>4__this; //Field offset: 0x20
		public int amount; //Field offset: 0x28
		public int amountPrev; //Field offset: 0x2C
		private int <repeatIndex>5__2; //Field offset: 0x30
		private string <amountText>5__3; //Field offset: 0x38
		private string <diffAmountText>5__4; //Field offset: 0x40

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
		public <SetMoneyTextAnimationCoroutine>d__45(int <>1__state) { }

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

	private static readonly int PROP_SLIDER_TALK_LEVEL; //Field offset: 0x0
	private static readonly int PROP_SLIDER_BATTERY_LEVEL; //Field offset: 0x4
	private static readonly int PROP_SLIDER_HP_LEVEL; //Field offset: 0x8
	private static readonly int PROP_SLIDER_SIGNAL_STRENGTH; //Field offset: 0xC
	private static readonly Color ACTIVE_COLOR; //Field offset: 0x10
	private static readonly Color INACTIVE_COLOR; //Field offset: 0x20
	private static readonly Color WARNING_COLOR; //Field offset: 0x30
	private static readonly Color DANGER_COLOR; //Field offset: 0x40
	private static readonly Vector3 SIZE_EXPANDED; //Field offset: 0x50
	[SerializeField]
	private Transform _sizeTransform; //Field offset: 0x20
	[SerializeField]
	private MeshRenderer _renderer; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI _textMoney; //Field offset: 0x30
	[SerializeField]
	private Image _currencyIcon; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI _textChannel; //Field offset: 0x40
	[SerializeField]
	private TextMeshProUGUI _textChannelHeader; //Field offset: 0x48
	[SerializeField]
	private AudioSource _soundAlarm; //Field offset: 0x50
	[SerializeField]
	private Image _healthFill; //Field offset: 0x58
	[SerializeField]
	private Image _healthIcon; //Field offset: 0x60
	[SerializeField]
	private Image _lootFill; //Field offset: 0x68
	[SerializeField]
	private Image _lootIcon; //Field offset: 0x70
	[SerializeField]
	private Image _weightFill; //Field offset: 0x78
	[SerializeField]
	private Image _weightIcon; //Field offset: 0x80
	[SerializeField]
	private RectTransform _directionRoot; //Field offset: 0x88
	[SerializeField]
	private MapIconView _playerIconPrefab; //Field offset: 0x90
	[SerializeField]
	private Sprite _playerIconSprite; //Field offset: 0x98
	[SerializeField]
	private Sprite _playerDeadIconSprite; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _mapIconsRoot; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _moneyDisplayRoot; //Field offset: 0xB0
	[SerializeField]
	private RectTransform _mapDisplayRoot; //Field offset: 0xB8
	[SerializeField]
	private MapView _mapView; //Field offset: 0xC0
	private IEnumerator _setMoneyTextAnimationCoroutine; //Field offset: 0xC8
	private WaitForSeconds _waitForHalfSeconds; //Field offset: 0xD0
	private WaitForSeconds _waitForOneSecond; //Field offset: 0xD8

	public MapView mapView
	{
		 get { } //Length: 8
	}

	private static PlayerWatchView() { }

	public PlayerWatchView() { }

	public MapView get_mapView() { }

	private string GetMoneyText(int amount) { }

	public void Initialize() { }

	public void SetBackpackStatus(bool equipped, float fillAmount) { }

	public void SetBatteryLevel(float level) { }

	public void SetChannelText(int channel) { }

	public void SetDisplay(WatchDisplay display) { }

	public void SetExpandSize(bool expand) { }

	public void SetHPLevel(float level) { }

	public void SetLED(bool isOn) { }

	public void SetMoneyText(int amount) { }

	public void SetMoneyText(int amount, int amountPrev, bool animate) { }

	[IteratorStateMachine(typeof(<SetMoneyTextAnimationCoroutine>d__45))]
	private IEnumerator SetMoneyTextAnimationCoroutine(int amount, int amountPrev) { }

	public void SetSignalStrength(float level) { }

	public void SetWeight(float weightNormalized) { }

	private void Update() { }

}

