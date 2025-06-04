namespace Photon.Realtime;

public class WebFlags
{
	public static readonly WebFlags Default; //Field offset: 0x0
	public const byte HttpForwardConst = 1; //Field offset: 0x0
	public const byte SendAuthCookieConst = 2; //Field offset: 0x0
	public const byte SendSyncConst = 4; //Field offset: 0x0
	public const byte SendStateConst = 8; //Field offset: 0x0
	public byte WebhookFlags; //Field offset: 0x10

	public bool HttpForward
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	public bool SendAuthCookie
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public bool SendState
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	public bool SendSync
	{
		 get { } //Length: 12
		 set { } //Length: 32
	}

	private static WebFlags() { }

	public WebFlags(byte webhookFlags) { }

	public bool get_HttpForward() { }

	public bool get_SendAuthCookie() { }

	public bool get_SendState() { }

	public bool get_SendSync() { }

	public void set_HttpForward(bool value) { }

	public void set_SendAuthCookie(bool value) { }

	public void set_SendState(bool value) { }

	public void set_SendSync(bool value) { }

}

