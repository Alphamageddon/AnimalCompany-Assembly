// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "PlayerControlAsset", menuName = "PlayerControlAsset", order = 0)]
    public class PlayerControlAsset : ScriptableObject
    {
        public int velocityHistorySize = 8;
        public float maxArmLength;
        public float unStickDistance;
        public float velocityLimit;
        public float maxJumpSpeed;
        public float jumpMultiplier;
        public float minimumRaycastDistance;
        public float defaultSlideFactor;
        public float defaultPrecision;
        public Vector3 leftHandOffset;
        public Vector3 rightHandOffset;
        public LayerMask locomotionEnabledLayers;

        public PlayerControlAsset()
        {
        }

        public void Setup(GorillaLocomotion.Player player)
        {
            if (player == null)
                return;

            player.velocityHistorySize = this.velocityHistorySize;
            player.maxArmLength = this.maxArmLength;
            player.unStickDistance = this.unStickDistance;
            player.velocityLimit = this.velocityLimit;
            player.maxJumpSpeed = this.maxJumpSpeed;
            player.jumpMultiplier = this.jumpMultiplier;
            player.minimumRaycastDistance = this.minimumRaycastDistance;
            player.defaultSlideFactor = this.defaultSlideFactor;
            player.defaultPrecision = this.defaultPrecision;
            player.leftHandOffset = this.leftHandOffset;
            player.rightHandOffset = this.rightHandOffset;
            player.locomotionEnabledLayers = this.locomotionEnabledLayers;
        }
    }
}