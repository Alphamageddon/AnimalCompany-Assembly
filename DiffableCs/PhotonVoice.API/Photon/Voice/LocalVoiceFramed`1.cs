namespace Photon.Voice;

public class LocalVoiceFramed : LocalVoice
{
	private Framer<T> framer; //Field offset: 0x0
	private int preProcessorsCnt; //Field offset: 0x0
	private List<IProcessor`1<T>> processors; //Field offset: 0x0
	private bool dataEncodeThreadStarted; //Field offset: 0x0
	private Queue<T[]> pushDataQueue; //Field offset: 0x0
	private AutoResetEvent pushDataQueueReady; //Field offset: 0x0
	private FactoryPrimitiveArrayPool<T> bufferFactory; //Field offset: 0x0
	private int framesSkippedNextLog; //Field offset: 0x0
	private int framesSkipped; //Field offset: 0x0
	private bool exitThread; //Field offset: 0x0
	private int processNullFramesCnt; //Field offset: 0x0

	public FactoryPrimitiveArrayPool<T> BufferFactory
	{
		 get { } //Length: 8
	}

	public bool PushDataAsyncReady
	{
		 get { } //Length: 216
	}

	internal LocalVoiceFramed`1(VoiceClient voiceClient, byte id, VoiceInfo voiceInfo, int inSampleRate, int channelId, VoiceCreateOptions opt) { }

	public void AddPostProcessor(IProcessor<T>[] processors) { }

	public void AddPreProcessor(IProcessor<T>[] processors) { }

	public void ClearProcessors() { }

	public virtual void Dispose() { }

	public FactoryPrimitiveArrayPool<T> get_BufferFactory() { }

	public bool get_PushDataAsyncReady() { }

	protected T[] processFrame(T[] buf, int p0, int p1) { }

	public void PushData(T[] buf) { }

	public void PushDataAsync(T[] buf) { }

	private void PushDataAsyncThread() { }

	public void RemoveProcessor(IProcessor<T>[] processors) { }

}

