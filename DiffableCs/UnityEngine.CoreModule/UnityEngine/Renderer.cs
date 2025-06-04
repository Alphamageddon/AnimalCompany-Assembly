namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		 get { } //Length: 104
	}

	public bool enabled
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public bool isPartOfStaticBatch
	{
		[NativeName("IsPartOfStaticBatch")]
		 get { } //Length: 60
	}

	public Bounds localBounds
	{
		[NativeName("SetLocalAABB")]
		 set { } //Length: 68
	}

	public Material material
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Material[] materials
	{
		 get { } //Length: 60
		 set { } //Length: 4
	}

	public bool receiveShadows
	{
		 set { } //Length: 68
	}

	public ShadowCastingMode shadowCastingMode
	{
		 set { } //Length: 68
	}

	public Material sharedMaterial
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 60
		 set { } //Length: 4
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 60
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 60
	}

	public int sortingLayerID
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public int sortingOrder
	{
		 get { } //Length: 60
		 set { } //Length: 68
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 108
	}

	public Renderer() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private void CopyMaterialArray(out Material[] m) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = True)]
	private void CopySharedMaterialArray(out Material[] m) { }

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	[NativeName("IsPartOfStaticBatch")]
	public bool get_isPartOfStaticBatch() { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	internal int get_sortingGroupID() { }

	internal int get_sortingGroupOrder() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private Material[] GetMaterialArray() { }

	private int GetMaterialCount() { }

	public void GetMaterials(List<Material> m) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray() { }

	public void GetSharedMaterials(List<Material> m) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	public void set_enabled(bool value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private void set_localBounds_Injected(ref Bounds value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_receiveShadows(bool value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingOrder(int value) { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	private void SetMaterialArray(Material[] m) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

