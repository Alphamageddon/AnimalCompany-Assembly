namespace AnimalCompany.GameGen;

public class GenerationNodeHandle
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GenBranch, Boolean> <>9__9_2; //Field offset: 0x8
		public static Func<Socket, Boolean> <>9__9_4; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <TryGenerate>b__9_2(GenBranch b) { }

		internal bool <TryGenerate>b__9_4(Socket s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Archetype fromArchetype; //Field offset: 0x10
		public Func<NodeGenerationResult, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <TryGenerate>b__0(List<NodeGenerationResult> rList) { }

		internal bool <TryGenerate>b__1(NodeGenerationResult r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public GenBranch branch; //Field offset: 0x10

		public <>c__DisplayClass9_1() { }

		internal bool <TryGenerate>b__3(Socket s) { }

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

