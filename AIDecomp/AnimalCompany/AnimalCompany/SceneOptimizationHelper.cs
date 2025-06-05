using UnityEngine;
using TMPro;

namespace AnimalCompany
{
    public class SceneOptimizationHelper : MonoBehaviour
    {
        [SerializeField]
        private string _materialNameToCheck;
        
        [SerializeField]
        private TMP_FontAsset[] _fontsAllowed;
        
        [SerializeField]
        private Shader[] _shaderAllowed;

        public SceneOptimizationHelper()
        {
        }
    }
}