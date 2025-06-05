// Decompiled with Xera AI Decompiler
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

namespace AnimalCompany
{
    public class DebugView : MonoBehaviour
    {
        private static DebugView _instance;
        
        [SerializeField]
        private TextMeshProUGUI _textDebug;
        
        [SerializeField]
        private XRBaseController _xrControllerLeft;
        
        private Dictionary<string, string> _textsToShow;
        private bool _needUpdateText;

        public DebugView()
        {
            _textsToShow = new Dictionary<string, string>();
        }

        public static void AddText(string key, string text)
        {
            if (_instance != null && _instance._textsToShow != null)
            {
                if (_instance._textsToShow.ContainsKey(key))
                {
                    _instance._textsToShow[key] = text;
                }
                else
                {
                    _instance._textsToShow.Add(key, text);
                }
                _instance._needUpdateText = true;
            }
        }

        private void Awake()
        {
            _instance = this;
            _textsToShow = new Dictionary<string, string>();
        }

        private void Update()
        {
            if (_needUpdateText)
            {
                _needUpdateText = false;
                
                if (_textDebug != null)
                {
                    string combinedText = "";
                    foreach (var kvp in _textsToShow)
                    {
                        combinedText += kvp.Key + ": " + kvp.Value + "\n";
                    }
                    _textDebug.text = combinedText;
                }
            }
        }
    }
}