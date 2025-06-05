using UnityEngine;
using UnityEngine.UI;

namespace AnimalCompany
{
    public class MapIconView : MonoBehaviour
    {
        [SerializeField]
        private Image _icon;
        
        [SerializeField]
        private Image _overlayIcon;
        
        private RectTransform _rectTransform;

        public RectTransform rectTransform
        {
            get { return _rectTransform; }
        }

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        public void SetIconSprite(Sprite sprite)
        {
            if (_icon != null)
            {
                _icon.sprite = sprite;
            }
        }

        public void SetIconColor(Color color)
        {
            if (_icon != null)
            {
                _icon.color = color;
            }
        }

        public void SetXOut(bool xOut)
        {
            if (_overlayIcon != null)
            {
                _overlayIcon.gameObject.SetActive(xOut);
            }
        }
    }
}