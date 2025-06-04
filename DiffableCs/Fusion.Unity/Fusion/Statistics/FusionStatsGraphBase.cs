namespace Fusion.Statistics;

public abstract class FusionStatsGraphBase : MonoBehaviour
{
	[DefaultMember("Item")]
	public struct FusionStatBuffer
	{
		private readonly Single[] _buffer; //Field offset: 0x0
		private int _index; //Field offset: 0x8
		private int _count; //Field offset: 0xC
		private int _zeroCount; //Field offset: 0x10
		private bool _ignoreZeroOnAverage; //Field offset: 0x14
		private TimeSpan _accumulateTimeSpan; //Field offset: 0x18
		private float _sum; //Field offset: 0x20
		private float _max; //Field offset: 0x24
		private float _accumulated; //Field offset: 0x28
		private DateTime _lastBufferInsertTime; //Field offset: 0x30

		public float AverageValue
		{
			 get { } //Length: 48
		}

		public int Index
		{
			 get { } //Length: 8
		}

		public float Item
		{
			 get { } //Length: 48
		}

		public float LatestValue
		{
			 get { } //Length: 84
		}

		public int Length
		{
			 get { } //Length: 28
		}

		public float MaxValue
		{
			 get { } //Length: 8
		}

		public FusionStatBuffer(int size, bool ignoreZeroOnAverage, int accumulateTimeMs) { }

		public void Add(float value, ref DateTime now) { }

		private void AddOnBuffer(float value) { }

		private float CalculateMax() { }

		public float get_AverageValue() { }

		public int get_Index() { }

		public float get_Item(int index) { }

		public float get_LatestValue() { }

		public int get_Length() { }

		public float get_MaxValue() { }

		public void SetAccumulateTime(int accumulateTimeMs) { }

		public void SetIgnoreZeroOnAverage(bool value) { }

	}

	private static readonly int Samples; //Field offset: 0x0
	private const string SHADER_PROPERTY_VALUES = "_Values"; //Field offset: 0x0
	private const string SHADER_PROPERTY_SAMPLES = "_Samples"; //Field offset: 0x0
	private const string SHADER_PROPERTY_THRESHOLD_1 = "_Threshold1"; //Field offset: 0x0
	private const string SHADER_PROPERTY_THRESHOLD_2 = "_Threshold2"; //Field offset: 0x0
	private const string SHADER_PROPERTY_THRESHOLD_3 = "_Threshold3"; //Field offset: 0x0
	private const string SHADER_PROPERTY_AVERAGE = "_Average"; //Field offset: 0x0
	private static readonly IFormatProvider _formatProvider; //Field offset: 0x8
	private static readonly String[][] LOOKUP_TABLE_0; //Field offset: 0x10
	private static readonly String[][] LOOKUP_TABLE_0ms; //Field offset: 0x18
	private static readonly String[][] LOOKUP_TABLE_0_BYTES; //Field offset: 0x20
	private static readonly String[][] LOOKUP_TABLE_0_00ms; //Field offset: 0x28
	private int _valuesShaderPropertyID; //Field offset: 0x20
	private int _threshold1ShaderPropertyID; //Field offset: 0x24
	private int _threshold2ShaderPropertyID; //Field offset: 0x28
	private int _threshold3ShaderPropertyID; //Field offset: 0x2C
	private int _averageShaderPropertyID; //Field offset: 0x30
	[SerializeField]
	private RectTransform _render; //Field offset: 0x38
	[SerializeField]
	private RectTransform _header; //Field offset: 0x40
	[SerializeField]
	private Image _targetImage; //Field offset: 0x48
	[SerializeField]
	private Button _toggleButton; //Field offset: 0x50
	[SerializeField]
	private Text _averageValueText; //Field offset: 0x58
	[SerializeField]
	private Text _peakValueText; //Field offset: 0x60
	[SerializeField]
	private Text _currentValueText; //Field offset: 0x68
	[SerializeField]
	[Space]
	private Text _threshold1Text; //Field offset: 0x70
	[SerializeField]
	private Text _threshold2Text; //Field offset: 0x78
	[SerializeField]
	private Text _threshold3Text; //Field offset: 0x80
	[SerializeField]
	[Space]
	protected float _valueTextMultiplier; //Field offset: 0x88
	[Range(60, 540)]
	[SerializeField]
	protected int _maxSamples; //Field offset: 0x8C
	[SerializeField]
	protected float _threshold1; //Field offset: 0x90
	[SerializeField]
	protected float _threshold2; //Field offset: 0x94
	[SerializeField]
	protected float _threshold3; //Field offset: 0x98
	[SerializeField]
	protected bool _ignoreZeroedValuesOnAverageCalculation; //Field offset: 0x9C
	[SerializeField]
	protected bool _ignoreZeroedValuesOnBuffer; //Field offset: 0x9D
	[SerializeField]
	protected float _valuesTextUpdateDelay; //Field offset: 0xA0
	private FusionStatBuffer _bufferValues; //Field offset: 0xA8
	private Single[] _bufferNormalizedValues; //Field offset: 0xE0
	private float _headerHeight; //Field offset: 0xE8
	private float _renderHeight; //Field offset: 0xEC
	private VerticalLayoutGroup _parentLayoutGroup; //Field offset: 0xF0
	private float _invertedRenderMaxValue; //Field offset: 0xF8
	private float _lastUpdateTime; //Field offset: 0xFC
	private Material _material; //Field offset: 0x100
	[SerializeField]
	private string _valueTextFormat; //Field offset: 0x108
	private String[][] _lookupTable; //Field offset: 0x110
	private float _lookupMultiplier; //Field offset: 0x118

	private bool Initialized
	{
		private get { } //Length: 16
	}

	private static FusionStatsGraphBase() { }

	protected FusionStatsGraphBase() { }

	protected override void AddValueToBuffer(float value, ref DateTime now) { }

	private bool get_Initialized() { }

	private string GetValueText(float value) { }

	protected override void Initialize(int accumulateTimeMs) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnSetValues() { }

	protected override void Refit() { }

	private float RemapValue(float value, float iMin, float iMax, float oMin, float oMax) { }

	protected override void Restore() { }

	protected void SetAccumulateTime(int accumulateTimeMs) { }

	protected override void SetGraphValues(Single[] values) { }

	protected void SetIgnoreZeroValues(bool ignoreZeroOnAverage, bool ignoreZeroOnBuffer) { }

	protected void SetThresholds(float threshold1, float threshold2, float threshold3) { }

	protected void SetValueTextFormat(string value) { }

	protected void SetValueTextMultiplier(float value) { }

	public override void ToggleRenderDisplay() { }

	public abstract void UpdateGraph(NetworkRunner runner, FusionStatisticsManager statisticsManager, ref DateTime now) { }

	private void UpdateThresholdPosition(Text text, float thresholdNormalized) { }

}

