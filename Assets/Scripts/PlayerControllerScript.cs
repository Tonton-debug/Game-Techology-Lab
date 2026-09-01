using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _gravity = -9.81f;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundDistance = 0.4f;
    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private float _jumpHeight = 6;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private PlayerAnimator _animatorScript;
    private Vector3 _moveVector;
    private float _upDownRange = 90;
    private Vector3 _velocity = new Vector3(0, -2, 0);
    private Vector2 _moveVector2;
    private float _rotationY;
    public bool IsGround => _isGrounded;
    void Start()
    {
        _animatorScript = GetComponent<PlayerAnimator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _controller.Move(_moveVector);
        ApplyPhysics();
    }
    public void Move(Vector2 move)
    {
        _moveVector2 = move;
        UpdateMoveVector();
    }
    private void ApplyPhysics()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        _animatorScript.SetIsGround(_isGrounded);
        _animatorScript.SetFallSpeed(_velocity.y);
        
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f; 
        }
        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
    public void Jump()
    {
        if (_isGrounded)
            _velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
    }
    private void UpdateMoveVector()
    {
        Vector3 moveVector = transform.forward * _moveVector2.y + transform.right * _moveVector2.x;
        moveVector *= _speed;
        _moveVector = moveVector;
        if (_moveVector == Vector3.zero)
        {
            _animatorScript.SetSpeed(0);
        } else
        {
            _animatorScript.SetSpeed(_speed);
        }
    }
    public void Rotate(Vector2 rotationVector)
    {
        float _verticalRot = rotationVector.x * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationVector.x * _rotationSpeed, 0);
     //   _rotationY -= rotationVector.y * _rotationSpeed;
      //  _rotationY = Mathf.Clamp(_rotationY, -_upDownRange, _upDownRange);
     //   _camera.transform.localRotation = Quaternion.Euler(_rotationY, 0, 0);
        UpdateMoveVector();
    }
}
