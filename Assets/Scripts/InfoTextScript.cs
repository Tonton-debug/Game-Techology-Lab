using TMPro;
using UnityEngine;

public class InfoTextScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Transform _playerTransform;
    void Start()
    {
        _text=GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Player Position:" + _playerTransform.position;

    }
}
