using UnityEngine;

public class CoinScript : MonoBehaviour
{
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin collected by: " + other.name);
        if (other.CompareTag("Player"))
        {
            PlayerInfoScript playerInfo = other.GetComponent<PlayerInfoScript>();
            if (playerInfo != null)
            {
                playerInfo.AddCoin();
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
