using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        _animator.SetBool("IsOpen", true);
    }
    private void OnTriggerExit(Collider other)
    {
        _animator.SetBool("IsOpen", false);
    }
}
