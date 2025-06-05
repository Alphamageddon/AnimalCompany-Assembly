// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class PrototypeSlenderAnimationSounds : MonoBehaviour
    {
        public RandomSFX footstepSFX;
        public RandomSFX standupSFX;
        public RandomSFX sitdownSFX;

        public PrototypeSlenderAnimationSounds()
        {
        }

        public void Footstep()
        {
            if (footstepSFX != null)
            {
                SFXManager.PlaySFX(footstepSFX, transform.position, 1f);
            }
        }

        public void Standup()
        {
            if (standupSFX != null)
            {
                SFXManager.PlaySFX(standupSFX, transform.position, 1f);
            }
        }

        public void Sitdown()
        {
            if (sitdownSFX != null)
            {
                SFXManager.PlaySFX(sitdownSFX, transform.position, 1f);
            }
        }
    }
}