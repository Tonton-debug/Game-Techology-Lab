using UnityEngine;

public class PlayerSript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TerrainIdScript _terrainScript;
    [SerializeField] private PlayerDieScript _dieScript;
    [SerializeField] private PlayerControllerScript _playerController;
   [SerializeField] private CapsuleCollider _collider;
    void Start()
    {
        _dieScript = GetComponent<PlayerDieScript>();
        _playerController = GetComponent<PlayerControllerScript>();
        _collider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_terrainScript.IsOnTexture(2)&& _playerController.IsGround)
        {
            _dieScript.Kill();
        }
       
       if(Physics.BoxCast(transform.position,new Vector3(_collider.height/2 ,_collider.radius,_collider.height/2), Vector3.down))
        {
            RaycastHit[] info=Physics.BoxCastAll(transform.position,new Vector3(_collider.height/2 ,_collider.radius,_collider.height/2), Vector3.down);
            foreach(RaycastHit i in info)
            {
                  Debug.Log("Hit object: " + i.collider.name);
            if(i.collider.CompareTag("Vrag"))
            {
                _dieScript.Kill();
            }
            }
          
        }
    }
 private void OnCollisionEnter(Collision collision)
{

        Debug.Log("Коснулся "+collision.collider.name);
    
}
}
