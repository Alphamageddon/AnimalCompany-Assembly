// Decompiled with Xera AI Decompiler
using UnityEngine;
using UnityEngine.InputSystem;
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    public class ReverbTest : MonoBehaviour
    {
        public RandomSFX _sfx;
        
        private InputAction testAction;
        
        public ReverbTest() { }
        
        private void Start()
        {
            testAction = new InputAction(binding: "<Keyboard>/space");
            testAction.performed += <Start>b__1_0;
            testAction.Enable();
        }
        
        [CompilerGenerated]
        private void <Start>b__1_0(InputAction.CallbackContext ctx)
        {
            if (_sfx != null)
            {
                Vector3 position = transform.position;
                SFXManager.PlaySFX(_sfx, position, 1f);
            }
        }
    }
}