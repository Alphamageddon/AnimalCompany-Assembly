namespace Photon.Voice;

public class AudioOutDelayControl
{
	internal struct PlayDelayConfig
	{
		public static PlayDelayConfig Default; //Field offset: 0x0
		public int Low; //Field offset: 0x0
		public int High; //Field offset: 0x4
		public int Max; //Field offset: 0x8
		public int SpeedUpPerc; //Field offset: 0xC

		private static PlayDelayConfig() { }

	}


	public AudioOutDelayControl() { }

}

