using TMPro;
using UnityEngine;

public class PlayerInfoScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextMeshProUGUI _infoMeshpro;
    [SerializeField] private int _coins;
    void Start()
    {
        _coins = 0;
        _infoMeshpro.text = "Coins: " + _coins;
    }
    public void AddCoin()
    {
        _coins++;
        _infoMeshpro.text = "Coins: " + _coins;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
