namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
internal sealed class ColorPalette : ScriptableObject, IHasDefault
{
	[CompilerGenerated]
	private Color <current>k__BackingField; //Field offset: 0x18
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private List<Color> m_Colors; //Field offset: 0x28

	public ReadOnlyCollection<Color> colors
	{
		 get { } //Length: 124
	}

	public int Count
	{
		 get { } //Length: 72
	}

	public Color current
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Color Item
	{
		 get { } //Length: 88
		 set { } //Length: 136
	}

	public ColorPalette() { }

	public ReadOnlyCollection<Color> get_colors() { }

	public int get_Count() { }

	[CompilerGenerated]
	public Color get_current() { }

	public Color get_Item(int i) { }

	[CompilerGenerated]
	public void set_current(Color value) { }

	public void set_Item(int i, Color value) { }

	public void SetColors(IEnumerable<Color> colors) { }

	public override void SetDefaultValues() { }

}

