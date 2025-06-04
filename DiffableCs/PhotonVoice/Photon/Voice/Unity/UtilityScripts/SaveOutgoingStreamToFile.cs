namespace Photon.Voice.Unity.UtilityScripts;

[DisallowMultipleComponent]
[RequireComponent(typeof(Recorder))]
public class SaveOutgoingStreamToFile : VoiceComponent
{
	private class OutgoingStreamSaverFloat : IProcessor<Single>, IDisposable
	{
		private WaveWriter wavWriter; //Field offset: 0x10

		public OutgoingStreamSaverFloat(WaveWriter waveWriter) { }

		public override void Dispose() { }

		public override Single[] Process(Single[] buf) { }

	}

	private class OutgoingStreamSaverShort : IProcessor<Int16>, IDisposable
	{
		private WaveWriter wavWriter; //Field offset: 0x10

		public OutgoingStreamSaverShort(WaveWriter waveWriter) { }

		public override void Dispose() { }

		public override Int16[] Process(Int16[] buf) { }

	}

	private WaveWriter wavWriter; //Field offset: 0x28

	public SaveOutgoingStreamToFile() { }

	private string GetFilePath() { }

	private void PhotonVoiceCreated(PhotonVoiceCreatedParams photonVoiceCreatedParams) { }

	private void PhotonVoiceRemoved() { }

}

