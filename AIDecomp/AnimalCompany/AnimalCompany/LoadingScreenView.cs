// Decompiled with Xera AI Decompiler
using UnityEngine;
using TMPro;

namespace AnimalCompany
{
    public class LoadingScreenView : MonoBehaviour
    {
        private static LoadingScreenView _instance;
        
        [SerializeField]
        private GameObject _loadingTextGO;
        
        [SerializeField]
        private TextMeshPro _versionText;
        
        [SerializeField]
        private TextMeshPro _statusText;

        public LoadingScreenView()
        {
        }

        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
            
            if (_versionText != null)
            {
                _versionText.text = "v" + Application.version;
            }

            if (_statusText != null && _statusText.gameObject != null)
            {
                _statusText.gameObject.SetActive(false);
            }
        }

        private void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }

        public static void SetStatus(string status, bool showLoading)
        {
            if (_instance == null)
                return;

            if (_instance._loadingTextGO != null)
            {
                _instance._loadingTextGO.SetActive(showLoading);
            }

            bool hasStatus = !string.IsNullOrEmpty(status);
            
            if (_instance._statusText != null && _instance._statusText.gameObject != null)
            {
                _instance._statusText.gameObject.SetActive(hasStatus);
            }

            if (!hasStatus)
                return;

            if (_instance._statusText != null)
            {
                _instance._statusText.text = status;
            }
        }
    }
}