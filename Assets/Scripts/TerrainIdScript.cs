using UnityEngine;

public class TerrainIdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   [SerializeField] private Terrain terrain;
    [SerializeField] private Transform _trans;
    public int Id => _textureIndex;
    private int _textureIndex;
    void Update()
    {
        _textureIndex = GetMainTexture(_trans.position);
        if(IsOnTexture(_textureIndex))
        Debug.Log("Игрок стоит на текстуре: " + _textureIndex);
    }
    public bool IsOnTexture(int index, float threshold = 0.5f)
    {
        return GetTextureWeight(index) > threshold;
    }

    float GetTextureWeight(int index)
    {
        TerrainData terrainData = terrain.terrainData;

        Vector3 terrainPos = _trans.position - terrain.transform.position;

        int mapX = (int)((terrainPos.x / terrainData.size.x) * terrainData.alphamapWidth);
        int mapZ = (int)((terrainPos.z / terrainData.size.z) * terrainData.alphamapHeight);

        float[,,] alphaMap = terrainData.GetAlphamaps(mapX, mapZ, 1, 1);

        return alphaMap[0, 0, index];
    }
    int GetMainTexture(Vector3 worldPos)
    {
        TerrainData terrainData = terrain.terrainData;

        Vector3 terrainPos = worldPos - terrain.transform.position;

        int mapX = (int)((terrainPos.x / terrainData.size.x) * terrainData.alphamapWidth);
        int mapZ = (int)((terrainPos.z / terrainData.size.z) * terrainData.alphamapHeight);

        float[,,] alphaMap = terrainData.GetAlphamaps(mapX, mapZ, 1, 1);

        float max = 0;
        int index = 0;

        for (int i = 0; i < alphaMap.GetLength(2); i++)
        {
            if (alphaMap[0, 0, i] > max)
            {
                max = alphaMap[0, 0, i];
                index = i;
            }
        }

        return index;
    }
}
