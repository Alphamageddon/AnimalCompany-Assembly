namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable
{
	protected int BlockSizeValue; //Field offset: 0x10
	protected int FeedbackSizeValue; //Field offset: 0x14
	protected Byte[] IVValue; //Field offset: 0x18
	protected Byte[] KeyValue; //Field offset: 0x20
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x28
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x30
	protected int KeySizeValue; //Field offset: 0x38
	protected CipherMode ModeValue; //Field offset: 0x3C
	protected PaddingMode PaddingValue; //Field offset: 0x40

	public override int BlockSize
	{
		 get { } //Length: 8
		 set { } //Length: 232
	}

	public override int FeedbackSize
	{
		 get { } //Length: 8
	}

	public override Byte[] IV
	{
		 get { } //Length: 148
		 set { } //Length: 348
	}

	public override Byte[] Key
	{
		 get { } //Length: 148
		 set { } //Length: 340
	}

	public override int KeySize
	{
		 get { } //Length: 8
		 set { } //Length: 124
	}

	public override KeySizes[] LegalKeySizes
	{
		 get { } //Length: 120
	}

	public override CipherMode Mode
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	public override PaddingMode Padding
	{
		 get { } //Length: 8
		 set { } //Length: 116
	}

	protected SymmetricAlgorithm() { }

	public void Clear() { }

	public static SymmetricAlgorithm Create(string algName) { }

	public abstract ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public override ICryptoTransform CreateDecryptor() { }

	public abstract ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract void GenerateIV() { }

	public abstract void GenerateKey() { }

	public override int get_BlockSize() { }

	public override int get_FeedbackSize() { }

	public override Byte[] get_IV() { }

	public override Byte[] get_Key() { }

	public override int get_KeySize() { }

	public override KeySizes[] get_LegalKeySizes() { }

	public override CipherMode get_Mode() { }

	public override PaddingMode get_Padding() { }

	public override void set_BlockSize(int value) { }

	public override void set_IV(Byte[] value) { }

	public override void set_Key(Byte[] value) { }

	public override void set_KeySize(int value) { }

	public override void set_Mode(CipherMode value) { }

	public override void set_Padding(PaddingMode value) { }

	public bool ValidKeySize(int bitLength) { }

}

