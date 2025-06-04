namespace AnimalCompany;

public class TerminalCommandProcessor
{
	private Dictionary<String, Object> _fileSystem; //Field offset: 0x10
	private string _currentDirectory; //Field offset: 0x18

	public TerminalCommandProcessor(string username) { }

	private void AppendLog(string message) { }

	private string ChangeDirectory(string path) { }

	private string CreateFile(string fileName, string content = "") { }

	private string DisplayFileContent(string fileName) { }

	private string EchoCommand(String[] args) { }

	private Dictionary<String, Object> GetDirectory(string path) { }

	private string GetFile(string path) { }

	private string GetHelp() { }

	private string ListFilesAndDirs() { }

	private string MakeDirectory(string dirName) { }

	public string ProcessCommand(string input) { }

	private string RemoveFile(string fileName) { }

	private string WriteToFile(string path, string content) { }

}

