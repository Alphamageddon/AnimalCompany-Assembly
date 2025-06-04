namespace AnimalCompany;

public class ApplyLogSettingsAction : BaseAction
{
	private LogLevel _logLevel; //Field offset: 0x14
	private LogChannel _logChannelFlags; //Field offset: 0x18
	private LogLevel _remoteLogLevel; //Field offset: 0x1C
	private LogChannel _remoteLogChannelFlags; //Field offset: 0x20

	public ApplyLogSettingsAction(LogLevel logLevel, LogChannel logChannelFlags, LogLevel remoteLogLevel, LogChannel remoteLogChannelFlags) { }

	public virtual void Execute(AppState state) { }

}

