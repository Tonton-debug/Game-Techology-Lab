using UnityEngine;

public class PlayerSript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TerrainIdScript _terrainScript;
    [SerializeField] private PlayerDieScript _dieScript;
    [SerializeField] private PlayerControllerScript _playerController;
    void Start()
    {
        _dieScript = GetComponent<PlayerDieScript>();
        _playerController = GetComponent<PlayerControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_terrainScript.IsOnTexture(2)&& _playerController.IsGround)
        {
            _dieScript.Kill();
        }
    }
}
