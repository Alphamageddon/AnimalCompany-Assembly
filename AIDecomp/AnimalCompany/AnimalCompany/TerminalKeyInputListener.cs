using System;
using UnityEngine;

namespace AnimalCompany
{
    public class TerminalKeyInputListener : MonoBehaviour
    {
        public Action<KeyCode, TerminalKeyType> onKeyInput;

        public TerminalKeyInputListener()
        {
        }

        public void AddKeyInput(KeyCode keyCode, TerminalKeyType keyType)
        {
            if (onKeyInput != null)
            {
                onKeyInput(keyCode, keyType);
            }
        }
    }
}