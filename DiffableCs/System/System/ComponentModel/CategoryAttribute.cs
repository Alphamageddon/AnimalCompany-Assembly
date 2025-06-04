namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class CategoryAttribute : Attribute
{
	private bool localized; //Field offset: 0x10
	private string categoryValue; //Field offset: 0x18

	public string Category
	{
		 get { } //Length: 64
	}

	public CategoryAttribute(string category) { }

	public virtual bool Equals(object obj) { }

	public string get_Category() { }

	public virtual int GetHashCode() { }

	protected override string GetLocalizedString(string value) { }

}

