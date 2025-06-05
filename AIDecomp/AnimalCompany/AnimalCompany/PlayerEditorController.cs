// Decompiled with Xera AI Decompiler
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace AnimalCompany
{
    public class PlayerEditorController : MonoBehaviour
    {
        public static bool isEditorController;
        public static Transform editorControllerTransform;
        
        public bool useEditorController = true;
        
        [SerializeField]
        private RandomSFX footstepSFX;
        
        private float _footStepDistance = 1.5f;
        private float _footStepDistAccum;
        private Vector3 _prevPosition;
        
        [SerializeField]
        private Player _player;
        
        [SerializeField]
        private Rigidbody _playerRigidbody;
        
        [SerializeField]
        private XRController _xrControllerLeft;
        
        [SerializeField]
        private XRController _xrControllerRight;
        
        [SerializeField]
        private TrackedPoseDriver _trackedPoseDriverHead;
        
        public InputAction playerControl;
        public InputAction inputActionDash;
        public InputAction inputActionJump;
        public InputAction inputActionMouseInput;
        public InputAction inputActionMouseClick;
        
        private InputAction _inputActionTestKey1;
        private InputAction _inputActionTestKey2;
        private InputAction _inputActionTestKey3;
        
        public AudioSource windAudioSource;
        public Vector2 windSpeedRange = new Vector2(0.1f, 0.8f);
        
        private Rigidbody _rigidbody;
        private float movementSpeed = 50f;
        private float fastMovementSpeed;
        
        public float freeLookSensitivity;
        public float zoomSensitivity;
        public float fastZoomSensitivity;
        
        private bool looking;
        private bool _isFastMode;

        public PlayerEditorController()
        {
        }

        private void Awake()
        {
            if (!isEditorController)
            {
                isEditorController = true;
                editorControllerTransform = transform;
            }
            
            _prevPosition = transform.position;
        }
    }
}