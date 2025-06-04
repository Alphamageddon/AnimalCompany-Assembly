namespace SpatialSys.ObservableState;

public static class PrimitiveOperators
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__2_0(string a, string b) { }

		internal bool <.cctor>b__2_1(char a, char b) { }

		internal short <.cctor>b__2_10(short a, short b) { }

		internal bool <.cctor>b__2_11(short a, short b) { }

		internal int <.cctor>b__2_12(int a, int b) { }

		internal int <.cctor>b__2_13(int a, int b) { }

		internal bool <.cctor>b__2_14(int a, int b) { }

		internal long <.cctor>b__2_15(long a, long b) { }

		internal long <.cctor>b__2_16(long a, long b) { }

		internal bool <.cctor>b__2_17(long a, long b) { }

		internal float <.cctor>b__2_18(float a, float b) { }

		internal float <.cctor>b__2_19(float a, float b) { }

		internal bool <.cctor>b__2_2(bool a, bool b) { }

		internal bool <.cctor>b__2_20(float a, float b) { }

		internal double <.cctor>b__2_21(double a, double b) { }

		internal double <.cctor>b__2_22(double a, double b) { }

		internal bool <.cctor>b__2_23(double a, double b) { }

		internal decimal <.cctor>b__2_24(decimal a, decimal b) { }

		internal decimal <.cctor>b__2_25(decimal a, decimal b) { }

		internal bool <.cctor>b__2_26(decimal a, decimal b) { }

		internal ushort <.cctor>b__2_27(ushort a, ushort b) { }

		internal ushort <.cctor>b__2_28(ushort a, ushort b) { }

		internal bool <.cctor>b__2_29(ushort a, ushort b) { }

		internal byte <.cctor>b__2_3(byte a, byte b) { }

		internal uint <.cctor>b__2_30(uint a, uint b) { }

		internal uint <.cctor>b__2_31(uint a, uint b) { }

		internal bool <.cctor>b__2_32(uint a, uint b) { }

		internal ulong <.cctor>b__2_33(ulong a, ulong b) { }

		internal ulong <.cctor>b__2_34(ulong a, ulong b) { }

		internal bool <.cctor>b__2_35(ulong a, ulong b) { }

		internal Vector2 <.cctor>b__2_36(Vector2 a, Vector2 b) { }

		internal Vector2 <.cctor>b__2_37(Vector2 a, Vector2 b) { }

		internal bool <.cctor>b__2_38(Vector2 a, Vector2 b) { }

		internal Vector3 <.cctor>b__2_39(Vector3 a, Vector3 b) { }

		internal byte <.cctor>b__2_4(byte a, byte b) { }

		internal bool <.cctor>b__2_40(Vector3 a, Vector3 b) { }

		internal Vector4 <.cctor>b__2_41(Vector4 a, Vector4 b) { }

		internal bool <.cctor>b__2_42(Vector4 a, Vector4 b) { }

		internal Quaternion <.cctor>b__2_43(Quaternion a, Quaternion b) { }

		internal bool <.cctor>b__2_44(Quaternion a, Quaternion b) { }

		internal Color <.cctor>b__2_45(Color a, Color b) { }

		internal bool <.cctor>b__2_46(Color a, Color b) { }

		internal bool <.cctor>b__2_47(Color32 a, Color32 b) { }

		internal bool <.cctor>b__2_48(Rect a, Rect b) { }

		internal bool <.cctor>b__2_49(Bounds a, Bounds b) { }

		internal bool <.cctor>b__2_5(byte a, byte b) { }

		internal sbyte <.cctor>b__2_6(sbyte a, sbyte b) { }

		internal sbyte <.cctor>b__2_7(sbyte a, sbyte b) { }

		internal bool <.cctor>b__2_8(sbyte a, sbyte b) { }

		internal short <.cctor>b__2_9(short a, short b) { }

	}

	internal class Operators
	{
		public Func<T, T, T> add; //Field offset: 0x0
		public Func<T, T, T> multiply; //Field offset: 0x0
		public Func<T, T, Boolean> equals; //Field offset: 0x0

		public Operators`1() { }

	}

	private static Dictionary<Type, Object> _registeredOperators; //Field offset: 0x0

	private static PrimitiveOperators() { }

	public static void Register(Operators<T> operators) { }

	public static bool TryGet(out Operators<T>& operators) { }

}

