using Scripts.CameraLogic;
using Scripts.Infrastructure;
using Scripts.Services.Input;
using UnityEngine;

namespace Scripts.Hero
{
    [RequireComponent(typeof(CharacterController))]
    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField]private float _movmentSpeed;

        private IInputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;
            CameraFollow();
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;
            if(_inputService.Axis.sqrMagnitude > Constans.Epsilon)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();
                transform.forward = movementVector;
            }
            movementVector += Physics.gravity;
            _characterController.Move(_movmentSpeed * movementVector * Time.deltaTime);
        }

        private void CameraFollow()
        {
            _camera.GetComponent<CameraFollow>().Follow(gameObject);
        }
    }
}