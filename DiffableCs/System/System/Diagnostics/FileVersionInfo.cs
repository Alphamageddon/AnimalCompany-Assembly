namespace System.Diagnostics;

public sealed class FileVersionInfo
{
	private string comments; //Field offset: 0x10
	private string companyname; //Field offset: 0x18
	private string filedescription; //Field offset: 0x20
	private string filename; //Field offset: 0x28
	private string fileversion; //Field offset: 0x30
	private string internalname; //Field offset: 0x38
	private string language; //Field offset: 0x40
	private string legalcopyright; //Field offset: 0x48
	private string legaltrademarks; //Field offset: 0x50
	private string originalfilename; //Field offset: 0x58
	private string privatebuild; //Field offset: 0x60
	private string productname; //Field offset: 0x68
	private string productversion; //Field offset: 0x70
	private string specialbuild; //Field offset: 0x78
	private bool isdebug; //Field offset: 0x80
	private bool ispatched; //Field offset: 0x81
	private bool isprerelease; //Field offset: 0x82
	private bool isprivatebuild; //Field offset: 0x83
	private bool isspecialbuild; //Field offset: 0x84
	private int filemajorpart; //Field offset: 0x88
	private int fileminorpart; //Field offset: 0x8C
	private int filebuildpart; //Field offset: 0x90
	private int fileprivatepart; //Field offset: 0x94
	private int productmajorpart; //Field offset: 0x98
	private int productminorpart; //Field offset: 0x9C
	private int productbuildpart; //Field offset: 0xA0
	private int productprivatepart; //Field offset: 0xA4

	public string FileName
	{
		 get { } //Length: 8
	}

	public string ProductVersion
	{
		 get { } //Length: 8
	}

	private FileVersionInfo() { }

	private static void AppendFormat(StringBuilder sb, string format, Object[] args) { }

	public string get_FileName() { }

	public string get_ProductVersion() { }

	public static FileVersionInfo GetVersionInfo(string fileName) { }

	private void GetVersionInfo_icall(Char* fileName, int fileName_length) { }

	private void GetVersionInfo_internal(string fileName) { }

	public virtual string ToString() { }

}

