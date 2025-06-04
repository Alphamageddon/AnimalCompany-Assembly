namespace Unity.XR.CoreUtils.Datums;

public abstract class DatumProperty
{
	[SerializeField]
	private bool m_UseConstant; //Field offset: 0x0
	[SerializeField]
	private TValue m_ConstantValue; //Field offset: 0x0
	[SerializeField]
	private TDatum m_Variable; //Field offset: 0x0

	protected TValue ConstantValue
	{
		 get { } //Length: 8
	}

	protected Datum<TValue> Datum
	{
		 get { } //Length: 8
	}

	public TValue Value
	{
		 get { } //Length: 148
		 set { } //Length: 56
	}

	protected DatumProperty`2() { }

	protected DatumProperty`2(TValue value) { }

	protected DatumProperty`2(TDatum datum) { }

	protected TValue get_ConstantValue() { }

	protected Datum<TValue> get_Datum() { }

	public TValue get_Value() { }

	public static TValue op_Implicit(DatumProperty<TValue, TDatum> datumProperty) { }

	public void set_Value(TValue value) { }

}

