namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineEditorResources : ScriptableObject
{
	[ReloadGroup]
	internal sealed class MaterialResources
	{
		[Reload("Runtime/Materials/Lit.mat", Package::Root (1))]
		public Material lit; //Field offset: 0x10
		[Reload("Runtime/Materials/ParticlesUnlit.mat", Package::Root (1))]
		public Material particleLit; //Field offset: 0x18
		[Reload("Runtime/Materials/TerrainLit.mat", Package::Root (1))]
		public Material terrainLit; //Field offset: 0x20
		[Reload("Runtime/Materials/Decal.mat", Package::Root (1))]
		public Material decal; //Field offset: 0x28

		public MaterialResources() { }

	}

	[ReloadGroup]
	internal sealed class ShaderResources
	{
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractive.shadergraph", Package::Root (1))]
		public Shader autodeskInteractivePS; //Field offset: 0x10
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveTransparent.shadergraph", Package::Root (1))]
		public Shader autodeskInteractiveTransparentPS; //Field offset: 0x18
		[Reload("Shaders/AutodeskInteractive/AutodeskInteractiveMasked.shadergraph", Package::Root (1))]
		public Shader autodeskInteractiveMaskedPS; //Field offset: 0x20
		[Reload("Shaders/Terrain/TerrainDetailLit.shader", Package::Root (1))]
		public Shader terrainDetailLitPS; //Field offset: 0x28
		[Reload("Shaders/Terrain/WavingGrass.shader", Package::Root (1))]
		public Shader terrainDetailGrassPS; //Field offset: 0x30
		[Reload("Shaders/Terrain/WavingGrassBillboard.shader", Package::Root (1))]
		public Shader terrainDetailGrassBillboardPS; //Field offset: 0x38
		[Reload("Shaders/Nature/SpeedTree7.shader", Package::Root (1))]
		public Shader defaultSpeedTree7PS; //Field offset: 0x40
		[Reload("Shaders/Nature/SpeedTree8_PBRLit.shadergraph", Package::Root (1))]
		public Shader defaultSpeedTree8PS; //Field offset: 0x48

		public ShaderResources() { }

	}

	public ShaderResources shaders; //Field offset: 0x18
	public MaterialResources materials; //Field offset: 0x20

	public UniversalRenderPipelineEditorResources() { }

}

