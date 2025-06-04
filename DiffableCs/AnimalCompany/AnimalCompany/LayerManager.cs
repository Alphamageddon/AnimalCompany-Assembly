namespace AnimalCompany;

public class LayerManager
{
	public const int LAYER_DEFAULT = 0; //Field offset: 0x0
	public const int LAYER_SOUND_COLLIDER = 27; //Field offset: 0x0
	public const int LAYER_LIGHT_COLLIDER = 26; //Field offset: 0x0
	public const int LAYER_ITEMONLY = 9; //Field offset: 0x0
	public const int LAYER_LOCALPLAYERONLYTRIGGER = 7; //Field offset: 0x0
	public const int LAYER_LOCALPLAYER = 6; //Field offset: 0x0
	public const int LAYER_NAVPOINT = 15; //Field offset: 0x0
	public const int LAYER_MONSTER = 11; //Field offset: 0x0
	public const int LAYER_ITEMHELD = 10; //Field offset: 0x0
	public static readonly LayerMask environmentLayer; //Field offset: 0x0
	public const int LAYER_SAFEZONE = 22; //Field offset: 0x0
	public const int LAYER_KILLZONE = 21; //Field offset: 0x0
	public const int LAYER_PLAYERONLYTRIGGER = 20; //Field offset: 0x0
	public const int LAYER_PLAYER = 8; //Field offset: 0x0
	public const int LAYER_ENVIRONMENT_HINGED = 16; //Field offset: 0x0
	public const int LAYER_ENVIRONMENT_INTERACTIVE = 13; //Field offset: 0x0
	public const int LAYER_ENVIRONMENT = 31; //Field offset: 0x0
	public const int LAYER_ITEM = 12; //Field offset: 0x0
	public static readonly LayerMask environmentInteractive; //Field offset: 0x4
	public static readonly LayerMask environmentHinged; //Field offset: 0x8
	public static readonly LayerMask playerLayer; //Field offset: 0xC
	public static readonly LayerMask itemLayer; //Field offset: 0x10
	public static readonly LayerMask itemHeldLayer; //Field offset: 0x14
	public static readonly LayerMask detectItemLayer; //Field offset: 0x18
	public static readonly LayerMask playerOnlyTriggerLayer; //Field offset: 0x1C
	public static readonly LayerMask killZoneLayer; //Field offset: 0x20
	public static readonly LayerMask safeZoneLayer; //Field offset: 0x24
	public static readonly LayerMask monsterLayer; //Field offset: 0x28
	public static readonly LayerMask navPointLayer; //Field offset: 0x2C
	public static readonly LayerMask localPlayerOnlyTriggerLayer; //Field offset: 0x30
	public static readonly LayerMask itemOnlyLayer; //Field offset: 0x34
	public static readonly LayerMask lightColliderLayer; //Field offset: 0x38
	public static readonly LayerMask soundColliderLayer; //Field offset: 0x3C
	public static readonly LayerMask locomotionEnabledLayers; //Field offset: 0x40
	public static readonly LayerMask damageableLayers; //Field offset: 0x44
	public static readonly LayerMask stunnableLayers; //Field offset: 0x48

	private static LayerManager() { }

	public LayerManager() { }

}

