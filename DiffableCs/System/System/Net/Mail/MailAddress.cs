namespace System.Net.Mail;

public class MailAddress
{
	private static readonly EncodedStreamFactory s_encoderFactory; //Field offset: 0x0
	private readonly Encoding _displayNameEncoding; //Field offset: 0x10
	private readonly string _displayName; //Field offset: 0x18
	private readonly string _userName; //Field offset: 0x20
	private readonly string _host; //Field offset: 0x28

	public string Address
	{
		 get { } //Length: 76
	}

	public string DisplayName
	{
		 get { } //Length: 8
	}

	private string SmtpAddress
	{
		private get { } //Length: 120
	}

	private static MailAddress() { }

	internal MailAddress(string displayName, string userName, string domain) { }

	public MailAddress(string address) { }

	public MailAddress(string address, string displayName, Encoding displayNameEncoding) { }

	public virtual bool Equals(object value) { }

	public string get_Address() { }

	public string get_DisplayName() { }

	private string get_SmtpAddress() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

