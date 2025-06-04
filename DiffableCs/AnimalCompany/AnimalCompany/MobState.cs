namespace AnimalCompany;

public class MobState
{
	[CompilerGenerated]
	private bool <isDie>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <health>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <angerMeter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <searchPrecision>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <searchWidth>k__BackingField; //Field offset: 0x20

	[Networked]
	public float angerMeter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Networked]
	public int health
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Networked]
	public bool isDie
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	[Networked]
	public float searchPrecision
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Networked]
	public float searchWidth
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MobState() { }

	[CompilerGenerated]
	public float get_angerMeter() { }

	[CompilerGenerated]
	public int get_health() { }

	[CompilerGenerated]
	public bool get_isDie() { }

	[CompilerGenerated]
	public float get_searchPrecision() { }

	[CompilerGenerated]
	public float get_searchWidth() { }

	[CompilerGenerated]
	public void set_angerMeter(float value) { }

	[CompilerGenerated]
	public void set_health(int value) { }

	[CompilerGenerated]
	public void set_isDie(bool value) { }

	[CompilerGenerated]
	public void set_searchPrecision(float value) { }

	[CompilerGenerated]
	public void set_searchWidth(float value) { }

}

