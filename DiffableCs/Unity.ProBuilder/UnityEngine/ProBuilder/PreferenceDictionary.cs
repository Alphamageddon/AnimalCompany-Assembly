namespace UnityEngine.ProBuilder;

internal sealed class PreferenceDictionary : ScriptableObject, ISerializationCallbackReceiver, IHasDefault
{
	private Dictionary<String, Boolean> m_Bool; //Field offset: 0x18
	private Dictionary<String, Int32> m_Int; //Field offset: 0x20
	private Dictionary<String, Single> m_Float; //Field offset: 0x28
	private Dictionary<String, String> m_String; //Field offset: 0x30
	private Dictionary<String, Color> m_Color; //Field offset: 0x38
	private Dictionary<String, Material> m_Material; //Field offset: 0x40
	[SerializeField]
	private List<String> m_Bool_keys; //Field offset: 0x48
	[SerializeField]
	private List<String> m_Int_keys; //Field offset: 0x50
	[SerializeField]
	private List<String> m_Float_keys; //Field offset: 0x58
	[SerializeField]
	private List<String> m_String_keys; //Field offset: 0x60
	[SerializeField]
	private List<String> m_Color_keys; //Field offset: 0x68
	[SerializeField]
	private List<String> m_Material_keys; //Field offset: 0x70
	[SerializeField]
	private List<Boolean> m_Bool_values; //Field offset: 0x78
	[SerializeField]
	private List<Int32> m_Int_values; //Field offset: 0x80
	[SerializeField]
	private List<Single> m_Float_values; //Field offset: 0x88
	[SerializeField]
	private List<String> m_String_values; //Field offset: 0x90
	[SerializeField]
	private List<Color> m_Color_values; //Field offset: 0x98
	[SerializeField]
	private List<Material> m_Material_values; //Field offset: 0xA0

	public PreferenceDictionary() { }

	public void Clear() { }

	public void DeleteKey(string key) { }

	public T Get(string key, T fallback = null) { }

	public bool GetBool(string key, bool fallback = false) { }

	public Dictionary<String, Boolean> GetBoolDictionary() { }

	public Color GetColor(string key, Color fallback = null) { }

	public Dictionary<String, Color> GetColorDictionary() { }

	public float GetFloat(string key, float fallback = 0) { }

	public Dictionary<String, Single> GetFloatDictionary() { }

	public int GetInt(string key, int fallback = 0) { }

	public Dictionary<String, Int32> GetIntDictionary() { }

	public Material GetMaterial(string key, Material fallback = null) { }

	public Dictionary<String, Material> GetMaterialDictionary() { }

	public string GetString(string key, string fallback = null) { }

	public Dictionary<String, String> GetStringDictionary() { }

	public bool HasKey(string key) { }

	public bool HasKey(string key) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void Set(string key, T value) { }

	public void SetBool(string key, bool value) { }

	public void SetColor(string key, Color value) { }

	public override void SetDefaultValues() { }

	public void SetFloat(string key, float value) { }

	public void SetInt(string key, int value) { }

	public void SetMaterial(string key, Material value) { }

	public void SetString(string key, string value) { }

}

