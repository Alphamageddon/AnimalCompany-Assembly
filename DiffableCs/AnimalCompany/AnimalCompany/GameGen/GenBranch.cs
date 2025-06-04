namespace AnimalCompany.GameGen;

public class GenBranch : ForceConnection, IForceConnectionStyle
{
	[Tooltip("If true mobs can roam across connections.")]
	public bool allowMobRoam; //Field offset: 0x28
	public string branchTag; //Field offset: 0x30

	public override Color ConnectionColor
	{
		 get { } //Length: 4
	}

	public override bool Dashed
	{
		 get { } //Length: 16
	}

	public GenBranch() { }

	public override Color get_ConnectionColor() { }

	public override bool get_Dashed() { }

	private Color GetConnectionColor() { }

	public ForceNode GetOtherNode(ForceNode node) { }

}

