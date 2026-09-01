using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerControllerScript _contorller;
    [SerializeField] private bool _locked=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void LockPrees(InputAction.CallbackContext callbackContext)
    {
      //  if (!callbackContext.started) return;
       // _locked = !_locked;
     //   UpdateLook();
    }
    private void UpdateLook()
    {
        Cursor.lockState = !_locked ? CursorLockMode.Locked : CursorLockMode.None;
        if (_locked)
            _contorller.Move(Vector2.zero);
    }
    public void SetLoock(bool loock)
    {
        _locked = loock;
        UpdateLook();
    }
    public void WASDPress(InputAction.CallbackContext callbackContext)
    {
        if (_locked) return;
        _contorller.Move(callbackContext.ReadValue<Vector2>());
    }


    public void MouseMove(InputAction.CallbackContext callbackContext)
    {
        if (_locked) return;
        _contorller.Rotate(callbackContext.ReadValue<Vector2>());
    }
    public void SpacePress(InputAction.CallbackContext callbackContext)
    {
        if (_locked) return;
        _contorller.Jump();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
