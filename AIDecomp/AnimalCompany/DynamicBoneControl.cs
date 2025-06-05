// Decompiled with Xera AI Decompiler
using UnityEngine;

public class DynamicBoneControl : MonoBehaviour
{
    internal class BoneGroup
    {
        public string name;
        public Transform[] bones;
        public Node[] nodes;
        public Vector3 rotationAxis;
        public Vector3 rotationOffset;
        
        [Header("Settings")]
        public float damping;
        
        [Range(0, 1)]
        public float drag;
        
        [Range(0, 1)]
        public float stiffness;

        public BoneGroup()
        {
        }
    }

    internal class Node
    {
        public Transform parent;
        public Vector3 pos;
        public Vector3 initialLocalPosition;
        public Quaternion initialLocalRotation;
        public Vector3 vel;
        public float lengthToParent;

        public Node(Transform parent, Vector3 pos, Vector3 initialLocalPosition, Quaternion initialLocalRotation)
        {
            this.parent = parent;
            this.pos = pos;
            this.initialLocalPosition = initialLocalPosition;
            this.initialLocalRotation = initialLocalRotation;
            this.vel = Vector3.zero;
            
            if (parent != null)
            {
                this.lengthToParent = Vector3.Distance(pos, parent.position);
            }
        }

        public void Update(Vector3 targetPos, float deltaTime, float damping, float drag, float stiffness)
        {
            Vector3 force = targetPos - pos;
            vel += force * stiffness * deltaTime;
            vel *= (1.0f - damping * deltaTime);
            vel *= (1.0f - drag);
            pos += vel * deltaTime;
        }
    }

    public bool isUpdate = true;
    
    [SerializeField]
    private Transform root;
    
    [SerializeField]
    private BoneGroup[] boneGroups;

    public DynamicBoneControl()
    {
    }

    private void OnEnable()
    {
        if (boneGroups == null) return;
        
        for (int i = 0; i < boneGroups.Length; i++)
        {
            BoneGroup group = boneGroups[i];
            if (group?.bones == null) continue;
            
            group.nodes = new Node[group.bones.Length];
            
            for (int j = 0; j < group.bones.Length; j++)
            {
                Transform bone = group.bones[j];
                if (bone == null) continue;
                
                Transform parentBone = bone.parent;
                Vector3 position = bone.position;
                Vector3 localPos = bone.localPosition;
                Quaternion localRot = bone.localRotation;
                
                group.nodes[j] = new Node(parentBone, position, localPos, localRot);
            }
        }
    }

    private void LateUpdate()
    {
        if (!isUpdate) return;
        if (boneGroups == null) return;
        
        float deltaTime = Time.deltaTime;
        
        for (int i = 0; i < boneGroups.Length; i++)
        {
            BoneGroup group = boneGroups[i];
            if (group?.bones == null || group.nodes == null) continue;
            
            for (int j = 0; j < group.bones.Length; j++)
            {
                Transform bone = group.bones[j];
                Node node = group.nodes[j];
                
                if (bone == null || node == null) continue;
                
                // Reset to initial rotation first
                bone.localRotation = node.initialLocalRotation;
                
                // Get target position
                Vector3 targetPos = bone.position;
                if (node.parent != null)
                {
                    targetPos = node.parent.TransformPoint(node.initialLocalPosition + group.rotationOffset);
                }
                
                // Update node physics
                node.Update(targetPos, deltaTime, group.damping, group.drag, group.stiffness);
                
                // Apply position
                bone.position = node.pos;
                
                // Calculate and apply rotation for chain
                if (j < group.bones.Length - 1)
                {
                    Transform nextBone = group.bones[j + 1];
                    if (nextBone != null)
                    {
                        Vector3 direction = (nextBone.position - bone.position).normalized;
                        if (direction != Vector3.zero)
                        {
                            Quaternion lookRotation = Quaternion.LookRotation(direction);
                            Quaternion offsetRotation = Quaternion.Euler(group.rotationAxis * Mathf.Deg2Rad);
                            bone.rotation = lookRotation * offsetRotation;
                        }
                    }
                }
            }
        }
    }
}