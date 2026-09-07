using System;
using UnityEngine;

public class ParticalsChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] _particals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < _particals.Length; i++)
        {
            _particals[i].SetActive(false);
        }
    }
    public void ChangeParticals(int index)
    {
        for (int i = 0; i < _particals.Length; i++)
        {
            if (i == index)
            {
                _particals[i].SetActive(true);
            }
            else
            {
                _particals[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
