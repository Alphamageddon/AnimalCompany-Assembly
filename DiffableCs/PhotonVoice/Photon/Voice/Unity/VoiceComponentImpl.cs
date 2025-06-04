namespace Photon.Voice.Unity;

public class VoiceComponentImpl
{
	private class LoggerImpl : ILogger
	{
		private VoiceLogger voiceLogger; //Field offset: 0x10
		private object obj; //Field offset: 0x18
		private string objName; //Field offset: 0x20
		private string tag; //Field offset: 0x28
		[CompilerGenerated]
		private LogLevel <Level>k__BackingField; //Field offset: 0x30

		public override LogLevel Level
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 8
		}

		public LoggerImpl() { }

		[CompilerGenerated]
		public override LogLevel get_Level() { }

		public override void Log(LogLevel level, string fmt, Object[] args) { }

		[CompilerGenerated]
		public void set_Level(LogLevel value) { }

		public void SetObjName(string n) { }

		public void SetVoiceLogger(VoiceLogger voiceLogger, object obj, string tag) { }

	}

	private VoiceLogger voiceLogger; //Field offset: 0x10
	private LoggerImpl logger; //Field offset: 0x18

	public ILogger Logger
	{
		 get { } //Length: 8
	}

	public string Name
	{
		 set { } //Length: 28
	}

	public VoiceLogger VoiceLogger
	{
		 get { } //Length: 8
	}

	public VoiceComponentImpl() { }

	public void Awake(MonoBehaviour mb) { }

	public ILogger get_Logger() { }

	public VoiceLogger get_VoiceLogger() { }

	public void set_Name(string value) { }

}

