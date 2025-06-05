// Decompiled with Xera AI Decompiler
using UnityEngine;
using UnityEngine.Rendering;

namespace AnimalCompany
{
    public class GraphicsSettingsManager : MonoBehaviour
    {
        public const string KEYWORD_DISABLE_CUSTOM_ATTEN = "_DISABLE_CUSTOM_ATTEN";
        
        private GlobalKeyword _disableCustomAttenKeyword;

        public GraphicsSettingsManager()
        {
        }

        private void Awake()
        {
            _disableCustomAttenKeyword = GlobalKeyword.Create(KEYWORD_DISABLE_CUSTOM_ATTEN);
            Shader.SetKeyword(_disableCustomAttenKeyword, false);
        }

        private void OnDestroy()
        {
            Shader.SetKeyword(_disableCustomAttenKeyword, true);
        }
    }
}