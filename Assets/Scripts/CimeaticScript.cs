using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CimeaticScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private CinemachineCamera _one;
    [SerializeField] private CinemachineCamera _two;
    private bool _revers = true;
    void Start()
    {
        
    }
    public void ReversInput(InputAction.CallbackContext callbackContext)
    {
        if (!callbackContext.started)
            return;
        Debug.Log("LAG:" + _revers+" "+ _one.Priority+" "+ _two.Priority);
        if (_revers)
        {
            _one.Priority.Value = 0;
            _two.Priority.Value = 1;
            _revers = false;
        }
        else
        {
            _two.Priority.Value = 0;
            _one.Priority.Value = 1;
            _revers = true;
        }
    }
}
