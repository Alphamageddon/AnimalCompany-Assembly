namespace mixpanel;

public class PlayerPreferences : IPreferences
{

	public PlayerPreferences() { }

	public override void DeleteKey(string key) { }

	public float GetFloat(string key) { }

	public override int GetInt(string key) { }

	public override int GetInt(string key, int defaultValue) { }

	public override string GetString(string key) { }

	public override string GetString(string key, string defaultValue) { }

	public override bool HasKey(string key) { }

	public override void SetInt(string key, int value) { }

	public override void SetString(string key, string value) { }

}

