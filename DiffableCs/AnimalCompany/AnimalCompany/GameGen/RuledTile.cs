namespace AnimalCompany.GameGen;

public class RuledTile : MonoBehaviour
{
	[Tooltip("Place the RuleTile prefab that this prefab is implementing here. This is used just to provide gizmos to help visualize the rules.")]
	public RuleTile ruleTilePrefab; //Field offset: 0x20
	public TileRuleType ruleType; //Field offset: 0x28

	public RuledTile() { }

	private void DrawWireframeGizmoInternal(float opacity) { }

	public bool GetIsRuleOrientationOpen(RuleOrientation ruleOrientation) { }

	private void OnDrawGizmos() { }

	public void RenderTile(Archetype archetype, RuleTile ruleTile) { }

}

