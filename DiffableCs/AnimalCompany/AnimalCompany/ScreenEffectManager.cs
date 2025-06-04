namespace AnimalCompany;

public class ScreenEffectManager : MonoBehaviour
{
	internal class FadeData
	{
		public float opacity; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public Action callbackEvent; //Field offset: 0x18

		public FadeData(float opacity, float duration, Action callbackEvent) { }

	}

	private static readonly int PROP_FADE_OPACITY; //Field offset: 0x0
	private const string KEYWORD_STUN_ENABLED = "STUN_ENABLED"; //Field offset: 0x0
	private const float HIT_EFFECT_DURATION = 0.15; //Field offset: 0x0
	private static readonly int PROP_FADE_COLOR; //Field offset: 0x4
	private static readonly int PROP_HIT_OPACITY; //Field offset: 0x8
	private static readonly int PROP_HIT_COLOR; //Field offset: 0xC
	private static readonly int PROP_STUN_INTENSITY; //Field offset: 0x10
	private static ScreenEffectManager _instance; //Field offset: 0x18
	[Header("References")]
	[SerializeField]
	private Material _passMaterial; //Field offset: 0x20
	private ScriptableRendererFeature _fullScreenPassRendererFeature; //Field offset: 0x28
	private bool _isInitialized; //Field offset: 0x30
	[Header("Fade")]
	private Queue<FadeData> _fadeOpacityDatas; //Field offset: 0x38
	private float _fadeOpacity; //Field offset: 0x40
	private float _fadeTimer; //Field offset: 0x44
	[Header("Hit")]
	private float _hitOpacity; //Field offset: 0x48
	[Header("Stun")]
	private float _stunIntensity; //Field offset: 0x4C
	private float _stunTimer; //Field offset: 0x50

	private static ScreenEffectManager() { }

	public ScreenEffectManager() { }

	private void Awake() { }

	public static void FadeIn(float duration = 0.5, Action callbackEvent = null, bool forceUpdate = true) { }

	public static void FadeInOut(float durationFadeIn = 0.5, float durationHold = 0.1, float durationFadeOut = 0.5, Action callbackEventFadeIn = null, Action callbackEventBeforeFadeOut = null, Action callbackEventFadeOut = null, bool forceUpdate = true) { }

	public static void FadeOut(float duration = 0.5, Action callbackEvent = null, bool forceUpdate = true) { }

	private void OnDestroy() { }

	public static void PlayerHit() { }

	public static void PlayerStun(float duration) { }

	public static void SetFadeColor(Color color) { }

	private static void SetFadeInternal(float opacity, float duration = 0.5, Action callbackEvent = null) { }

	private void Update() { }

	private void UpdateFade() { }

	private void UpdateHit() { }

	private void UpdateStun() { }

}

