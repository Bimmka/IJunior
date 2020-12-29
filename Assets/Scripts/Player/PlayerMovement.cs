using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour, IPlayerMovement
{
    [Header("Скорость движения персонажа")]
    [SerializeField] private float _moveSpeed = 10f;

    private Rigidbody _rigidbody;

    private MainInputActions _inputActions;

    private void Awake()
    {
        TryGetComponent(out _rigidbody);

        _inputActions = new MainInputActions();
    }

    private void OnEnable()
    {
        _inputActions.PlayerInputs.Enable();
    }

    private void OnDisable()
    {
        _inputActions.PlayerInputs.Disable();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 _moveDirection = _inputActions.PlayerInputs.Move.ReadValue<Vector2>();

        _rigidbody.AddForce(new Vector3(_moveDirection.x, 0f, _moveDirection.y) * _moveSpeed);
    }

    public void MovePlayerOnDirection(Vector3 _direction)
    {
        _rigidbody.AddForce(_direction * _moveSpeed);
    }
}
