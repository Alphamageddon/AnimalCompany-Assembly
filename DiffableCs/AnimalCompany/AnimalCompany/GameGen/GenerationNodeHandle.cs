namespace AnimalCompany.GameGen;

public class GenerationNodeHandle
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Archetype fromArchetype; //Field offset: 0x10
		public Func<NodeGenerationResult, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <TryGenerate>b__0(List<NodeGenerationResult> rList) { }

		internal bool <TryGenerate>b__1(NodeGenerationResult r) { }

	}

	public Generator generator; //Field offset: 0x10
	public GenGraph graph; //Field offset: 0x18
	public IGenerationNode node; //Field offset: 0x20
	public int depth; //Field offset: 0x28
	public GenBranch sourceBranch; //Field offset: 0x30
	public List<GenBranch> remainingBranches; //Field offset: 0x38
	public Socket sourceSocket; //Field offset: 0x40
	public Bounds sourceBounds; //Field offset: 0x48

	public GenerationNodeHandle(Generator generator, GenGraph graph, IGenerationNode node, int depth, GenBranch sourceBranch, Socket sourceSocket) { }

	public bool TryGenerate() { }

}

