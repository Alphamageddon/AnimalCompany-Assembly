// Decompiled with Xera AI Decompiler
using UnityEngine;
using TMPro;

namespace AnimalCompany
{
    public class Nametag : MonoBehaviour
    {
        [SerializeField]
        private TextMeshPro _tmp;
        [SerializeField]
        private Transform _attachPoint;
        [SerializeField]
        private SkinnedMeshRenderer _skinnedMesh;
        [SerializeField]
        private BoneWeight _boneWeight;
        [SerializeField]
        private int _attachedVertexIndex;
        [SerializeField]
        private Vector3 _baseVertexPosition;
        private Vector3[] _posBuf;

        public Nametag()
        {
            _posBuf = new Vector3[4];
        }

        private void CalcPositionWithBone(int boneIndex, ref Vector3 pos)
        {
            if (_skinnedMesh == null) return;

            Transform[] bones = _skinnedMesh.bones;
            if (bones == null || boneIndex >= bones.Length) return;

            Transform bone = bones[boneIndex];
            if (bone == null) return;

            Matrix4x4 localToWorld = bone.localToWorldMatrix;
            Matrix4x4[] bindposes = _skinnedMesh.sharedMesh.bindposes;
            if (bindposes == null || boneIndex >= bindposes.Length) return;

            Matrix4x4 bindpose = bindposes[boneIndex];
            Matrix4x4 boneMatrix = localToWorld * bindpose;
            pos = boneMatrix.MultiplyPoint(_baseVertexPosition);
        }

        private void LateUpdate()
        {
            if (_boneWeight.boneIndex0 >= 0)
            {
                CalcPositionWithBone(_boneWeight.boneIndex0, ref _posBuf[0]);
            }
            if (_boneWeight.boneIndex1 >= 0)
            {
                CalcPositionWithBone(_boneWeight.boneIndex1, ref _posBuf[1]);
            }
            if (_boneWeight.boneIndex2 >= 0)
            {
                CalcPositionWithBone(_boneWeight.boneIndex2, ref _posBuf[2]);
            }
            if (_boneWeight.boneIndex3 >= 0)
            {
                CalcPositionWithBone(_boneWeight.boneIndex3, ref _posBuf[3]);
            }

            if (_attachPoint != null)
            {
                Vector3 finalPos = _posBuf[0] * _boneWeight.weight0 +
                                  _posBuf[1] * _boneWeight.weight1 +
                                  _posBuf[2] * _boneWeight.weight2 +
                                  _posBuf[3] * _boneWeight.weight3;
                
                _attachPoint.position = finalPos;
            }
        }

        public void SetName(string name)
        {
            if (_tmp != null)
            {
                _tmp.SetText(name, true);
            }
        }

        [ContextMenu("Setup bone attachment")]
        private void SetupBoneAttachment()
        {
            if (_skinnedMesh == null) return;

            Vector3[] vertices = _skinnedMesh.sharedMesh.vertices;
            if (vertices == null || vertices.Length == 0) return;

            Matrix4x4 worldToLocal = _skinnedMesh.worldToLocalMatrix;
            Vector3 localAttachPoint = worldToLocal.MultiplyPoint(_attachPoint.position);

            float closestDistance = float.MaxValue;
            int closestVertexIndex = -1;

            for (int i = 0; i < vertices.Length; i++)
            {
                Vector3 vertex = vertices[i];
                float distance = Vector3.Distance(vertex, localAttachPoint);
                
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestVertexIndex = i;
                }
            }

            if (closestVertexIndex >= 0)
            {
                _attachedVertexIndex = closestVertexIndex;
                _baseVertexPosition = vertices[closestVertexIndex];

                BoneWeight[] boneWeights = _skinnedMesh.sharedMesh.boneWeights;
                if (boneWeights != null && closestVertexIndex < boneWeights.Length)
                {
                    _boneWeight = boneWeights[closestVertexIndex];
                }
            }
        }
    }
}