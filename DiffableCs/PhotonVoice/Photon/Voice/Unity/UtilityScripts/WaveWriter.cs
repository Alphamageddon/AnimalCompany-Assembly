namespace Photon.Voice.Unity.UtilityScripts;

public class WaveWriter : IDisposable
{
	private readonly long _waveStartPosition; //Field offset: 0x10
	private int _dataLength; //Field offset: 0x18
	private bool _isDisposed; //Field offset: 0x1C
	private Stream _stream; //Field offset: 0x20
	private BinaryWriter _writer; //Field offset: 0x28
	private int _sampleRate; //Field offset: 0x30
	private int _bitsPerSample; //Field offset: 0x34
	private int _channels; //Field offset: 0x38
	private readonly bool _closeStream; //Field offset: 0x3C

	public WaveWriter(string fileName, int sampleRate, int bits, int channels) { }

	public WaveWriter(Stream stream, int sampleRate, int bitsPerSample, int channels) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public void Write(Byte[] buffer, int offset, int count) { }

	public void Write(byte value) { }

	public void Write(short value) { }

	public void Write(int value) { }

	public void Write(float value) { }

	private void WriteHeader() { }

	public void WriteSample(float sample) { }

	public void WriteSamples(Single[] samples, int offset, int count) { }

}

