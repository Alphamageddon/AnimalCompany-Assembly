namespace UnityEngine.UIElements.Internal;

internal class MultiColumnHeaderColumn : VisualElement
{
	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string sortableUssClassName; //Field offset: 0x8
	public static readonly string sortedAscendingUssClassName; //Field offset: 0x10
	public static readonly string sortedDescendingUssClassName; //Field offset: 0x18
	public static readonly string movingUssClassName; //Field offset: 0x20
	public static readonly string contentContainerUssClassName; //Field offset: 0x28
	public static readonly string contentUssClassName; //Field offset: 0x30
	public static readonly string defaultContentUssClassName; //Field offset: 0x38
	public static readonly string hasIconUssClassName; //Field offset: 0x40
	public static readonly string hasTitleUssClassName; //Field offset: 0x48
	public static readonly string titleUssClassName; //Field offset: 0x50
	public static readonly string iconElementName; //Field offset: 0x58
	public static readonly string titleElementName; //Field offset: 0x60
	private static readonly string s_BoundVEPropertyName; //Field offset: 0x68
	private static readonly string s_BindingCallbackVEPropertyName; //Field offset: 0x70
	private static readonly string s_UnbindingCallbackVEPropertyName; //Field offset: 0x78
	private static readonly string s_DestroyCallbackVEPropertyName; //Field offset: 0x80
	private VisualElement m_ContentContainer; //Field offset: 0x3C8
	private VisualElement m_Content; //Field offset: 0x3D0
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; //Field offset: 0x3D8
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; //Field offset: 0x3E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Clickable <clickable>k__BackingField; //Field offset: 0x3E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ColumnMover <mover>k__BackingField; //Field offset: 0x3F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Column <column>k__BackingField; //Field offset: 0x3F8

	public private Clickable clickable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Column column
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public VisualElement content
	{
		 get { } //Length: 8
		 set { } //Length: 200
	}

	private bool isContentBound
	{
		private get { } //Length: 204
		private set { } //Length: 192
	}

	public private ColumnMover mover
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public string sortOrderLabel
	{
		 set { } //Length: 44
	}

	private static MultiColumnHeaderColumn() { }

	public MultiColumnHeaderColumn(Column column) { }

	[CompilerGenerated]
	private void <.ctor>b__45_0(Column c, ColumnDataType role) { }

	[CompilerGenerated]
	private void <.ctor>b__45_1(Column c) { }

	[CompilerGenerated]
	private void <InitManipulators>b__46_0(ColumnMover mv) { }

	private void BindHeaderContent() { }

	private VisualElement CreateDefaultHeaderContent() { }

	private void DefaultBindHeaderContent(VisualElement ve) { }

	private void DestroyHeaderContent() { }

	[CompilerGenerated]
	public Clickable get_clickable() { }

	[CompilerGenerated]
	public Column get_column() { }

	public VisualElement get_content() { }

	private bool get_isContentBound() { }

	[CompilerGenerated]
	public ColumnMover get_mover() { }

	private void InitManipulators() { }

	[CompilerGenerated]
	private void set_clickable(Clickable value) { }

	[CompilerGenerated]
	public void set_column(Column value) { }

	public void set_content(VisualElement value) { }

	private void set_isContentBound(bool value) { }

	[CompilerGenerated]
	private void set_mover(ColumnMover value) { }

	public void set_sortOrderLabel(string value) { }

	private void UnbindHeaderContent() { }

	private void UpdateDataFromColumn() { }

	private void UpdateGeometryFromColumn() { }

	private void UpdateHeaderTemplate() { }

}

