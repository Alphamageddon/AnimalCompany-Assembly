using UnityEngine;

namespace AnimalCompany
{
    [CreateAssetMenu(fileName = "MobData", menuName = "AnimalCompany/MobData", order = 1)]
    public class MobData : ScriptableObject
    {
        public string monsterName;
        public int health;
        public int attackDamage;
        
        [Header("AI-Roaming")]
        [Tooltip("Seconds between attacks")]
        public float attackSpeed;
        
        [Tooltip("Meter per second")]
        public float[] walkSpeed;
        
        [Tooltip("Meter per second")]
        public float[] runSpeed;
        
        [Tooltip("Degrees per second")]
        public float steeringSpeed;
        
        [Tooltip("Seconds")]
        public float timeHoldAtNavPoint;
        
        [Header("Physics")]
        public float bodySize;
        public float attackRange;
        public float attackForce;
        
        [Header("AI-Chasing")]
        public float[] searchPrecision;
        public float[] searchWidth;
        public float timeChasing;
        public float timeSearching;
        
        [Header("Sense")]
        public float fov;
        public float[] viewDistance;
        public float hearingDistance;
        public float hearingSensitivity;
        public float angerMeterToAttack;
        
        [Header("Respawn")]
        public bool isRespawnInRandomNavPoint;
        public float timeRevive;
        
        [Header("Sound")]
        public RandomSFX emergeSFX;
        public RandomSFX encounterSFX;
        public RandomSFX footstepSFX;
        public RandomSFX attackSFX;
        public RandomSFX killSFX;
        public RandomSFX hitSFX;
        public RandomSFX dieSFX;

        public float attackRangeSqr
        {
            get { return attackRange * attackRange; }
        }

        public float bodySizeSqr
        {
            get { return bodySize * bodySize; }
        }

        public float hearingDistanceSqr
        {
            get { return hearingDistance * hearingDistance; }
        }

        public MobData()
        {
            attackSpeed = 1f;
            walkSpeed = new float[1];
            runSpeed = new float[1];
            searchPrecision = new float[1];
            searchWidth = new float[1];
            viewDistance = new float[1];
        }
    }
}