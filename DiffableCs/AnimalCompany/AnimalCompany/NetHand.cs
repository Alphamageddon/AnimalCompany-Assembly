namespace AnimalCompany;

[NetworkBehaviourWeaved(3)]
public class NetHand : NetworkBehaviour
{
	[DefaultForProperty("stepID", 0, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private byte _stepID; //Field offset: 0x80
	[DefaultForProperty("volume", 1, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private byte _volume; //Field offset: 0x81
	[DefaultForProperty("sfxID", 2, 1)]
	[DrawIf("IsEditorWritable", True, CompareOperator::Equal (0), DrawIfMode::ReadOnly (0))]
	[SerializeField]
	[WeaverGenerated]
	private ushort _sfxID; //Field offset: 0x82

	[Networked]
	[NetworkedWeaved(2, 1)]
	public ushort sfxID
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(0, 1)]
	[OnChangedRender("HandleStepIDChanged")]
	public byte stepID
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	[Networked]
	[NetworkedWeaved(1, 1)]
	public byte volume
	{
		 get { } //Length: 96
		 set { } //Length: 96
	}

	public NetHand() { }

	[WeaverGenerated]
	public virtual void CopyBackingFieldsToState(bool unnamed_param_0) { }

	[WeaverGenerated]
	public virtual void CopyStateToBackingFields() { }

	public ushort get_sfxID() { }

	public byte get_stepID() { }

	public byte get_volume() { }

	public void HandleStep(RandomSFX sfx, float intensity) { }

	private void HandleStepIDChanged() { }

	public void set_sfxID(ushort value) { }

	public void set_stepID(byte value) { }

	public void set_volume(byte value) { }

}

