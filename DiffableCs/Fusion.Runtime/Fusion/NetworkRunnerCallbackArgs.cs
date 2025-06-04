namespace Fusion;

public static class NetworkRunnerCallbackArgs
{
	internal class ConnectRequest
	{
		[CompilerGenerated]
		private NetAddress <RemoteAddress>k__BackingField; //Field offset: 0x10
		internal Nullable<OnConnectionRequestReply> Result; //Field offset: 0x28

		public NetAddress RemoteAddress
		{
			[CompilerGenerated]
			 get { } //Length: 20
			[CompilerGenerated]
			 set { } //Length: 20
		}

		public ConnectRequest() { }

		public void Accept() { }

		[CompilerGenerated]
		public NetAddress get_RemoteAddress() { }

		public void Refuse() { }

		[CompilerGenerated]
		public void set_RemoteAddress(NetAddress value) { }

		public void Waiting() { }

	}


}

