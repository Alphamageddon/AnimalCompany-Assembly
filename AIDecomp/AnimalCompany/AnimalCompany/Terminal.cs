// Decompiled with Xera AI Decompiler
using UnityEngine;
using TMPro;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class Terminal : MonoBehaviour
    {
        internal sealed class OnCodeEnteredDelegate : System.MulticastDelegate
        {
            public OnCodeEnteredDelegate(object @object, System.IntPtr method) : base(@object, method) { }

            public override System.IAsyncResult BeginInvoke(string code, System.AsyncCallback callback, object @object)
            {
                return base.BeginInvoke(code, callback, @object);
            }

            public override bool EndInvoke(System.IAsyncResult result)
            {
                return (bool)base.EndInvoke(result);
            }

            public override bool Invoke(string code)
            {
                return (bool)base.DynamicInvoke(code);
            }
        }

        private static Terminal instance;
        public static OnCodeEnteredDelegate OnCodeEntered;
        
        public int maxInputLength = 8;
        public string input = "";
        public TextMeshProUGUI inputText;
        public TextMeshProUGUI roomCodeText;
        public TextMeshProUGUI appVersionText;
        
        private TerminalKeyInputListener _keyInputListener;

        private void Awake()
        {
            instance = this;
            
            _keyInputListener = GetComponent<TerminalKeyInputListener>();
            if (_keyInputListener != null)
            {
                _keyInputListener.OnKeyInput += HandleKeyInput;
            }

            var app = App.Instance;
            if (app != null && app.State != null && app.State.CurrentRoomCode != null)
            {
                app.RegisterObserver(new ObserverDelegate(this, HandleCurrentRoomCodeChanged));
            }

            if (appVersionText != null)
            {
                appVersionText.text = "v" + Application.version;
            }

            UpdateText();
        }

        private void OnDestroy()
        {
            if (_keyInputListener != null)
            {
                _keyInputListener.OnKeyInput -= HandleKeyInput;
            }

            var app = App.Instance;
            if (app != null)
            {
                app.DeregisterObserver(new ObserverDelegate(this, HandleCurrentRoomCodeChanged));
            }
        }

        private void HandleCurrentRoomCodeChanged(StateChangedEventArgs args)
        {
            var app = App.Instance;
            if (app != null && app.State != null && app.State.CurrentRoomCode != null)
            {
                string roomCode = app.State.CurrentRoomCode.Value;
                if (!string.IsNullOrEmpty(roomCode) && roomCodeText != null)
                {
                    roomCodeText.text = "Room: " + roomCode;
                }
            }
        }

        private void HandleKeyInput(KeyCode key, TerminalKeyType keyType)
        {
            if (keyType == TerminalKeyType.Character)
            {
                char keyChar = (char)key;
                if ((keyChar >= '0' && keyChar <= '9') || (keyChar >= 'a' && keyChar <= 'z'))
                {
                    AddKeyInput(keyChar.ToString());
                }
            }
            else if (keyType == TerminalKeyType.Backspace)
            {
                Backspace();
            }
            else if (keyType == TerminalKeyType.Enter)
            {
                Enter();
            }
        }

        public void AddKeyInput(string key)
        {
            if (input != null && input.Length < maxInputLength)
            {
                input = input + key;
                UpdateText();
            }
        }

        public void Backspace()
        {
            if (input != null && input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
                UpdateText();
            }
        }

        public void Enter()
        {
            if (OnCodeEntered != null)
            {
                bool result = OnCodeEntered.Invoke(input);
                if (result)
                {
                    input = "";
                    UpdateText();
                }
            }
        }

        private void UpdateText()
        {
            if (inputText != null)
            {
                inputText.text = input + "_";
            }
        }
    }
}