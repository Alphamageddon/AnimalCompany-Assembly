namespace Fusion.LagCompensation;

public struct QueryParams
{
	public HitOptions Options; //Field offset: 0x0
	public QueryTriggerInteraction TriggerInteraction; //Field offset: 0x4
	public LayerMask LayerMask; //Field offset: 0x8
	public PlayerRef Player; //Field offset: 0xC
	public int Tick; //Field offset: 0x10
	public Nullable<Int32> TickTo; //Field offset: 0x14
	public Nullable<Single> Alpha; //Field offset: 0x1C
	public PreProcessingDelegate PreProcessingDelegate; //Field offset: 0x28
	public Void* UserArgs; //Field offset: 0x30

}

