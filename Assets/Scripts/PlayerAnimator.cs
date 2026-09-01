using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SetIsGround(bool isGround)
    {
        _animator.SetBool("IsGround", isGround);
    }
    public void SetSpeed(float speed)
    {
       // Debug.Log("SAS:" + Mathf.FloorToInt(speed) + " " + speed);
        _animator.SetInteger("Speed", Mathf.CeilToInt(speed));
    }
    public void SetFallSpeed(float speed)
    {
        _animator.SetInteger("FallSpeed", (int)speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
