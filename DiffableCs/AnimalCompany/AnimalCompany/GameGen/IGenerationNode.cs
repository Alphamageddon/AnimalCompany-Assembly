namespace AnimalCompany.GameGen;

public interface IGenerationNode
{

	public NodeGenerationResponse Generate(Socket source, Generator generator) { }

}

