using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomHeights : MonoBehaviour
{

    private Terrain terrain;
    private TerrainData terrainData;

    [SerializeField]
    [Range(0f, 1f)]
    private float minRandomHeightRange = 0f; // min is 0
    
    [SerializeField]
    [Range(0f, 1f)]
    private float maxRandomHeightRange = 0.1f; //max is 1

    [SerializeField]
    private bool flatternTerrain = true;

    [Header("Perlin Noise")]
    [SerializeField]
    private bool perlinNoise = false;

    [SerializeField]
    private float perlinNoiseWidthScale = 0.01f;

    [SerializeField]
    private float perlinNoiseHeightScale = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        if(terrain == null) {
            terrain = this.GetComponent<Terrain>();
        }

        if(terrainData == null) {
            terrainData = Terrain.activeTerrain.terrainData;
        }

        //GenerateHeights();
    }

    void Update() {
        GenerateHeights();
    }

    private void GenerateHeights() {

        float[,] heightMap = new float[terrainData.heightmapResolution, terrainData.heightmapResolution];
    
        for(int width = 0; width < terrainData.heightmapResolution; width++) {
            for(int height = 0; height < terrainData.heightmapResolution; height++) {
                
                if(perlinNoise) {
                    heightMap[width, height] = Mathf.PerlinNoise(width * perlinNoiseWidthScale, height * perlinNoiseHeightScale);
                } 
                
                else {
                    heightMap[width, height] = Random.Range(minRandomHeightRange, maxRandomHeightRange);
                }
            }
        }

        terrainData.SetHeights(0, 0, heightMap);
    }

    private void FlatternTerrain() {

        float[,] heightMap = new float[terrainData.heightmapResolution, terrainData.heightmapResolution];
    
        for(int width = 0; width < terrainData.heightmapResolution; width++) {
            for(int height = 0; height < terrainData.heightmapResolution; height++) {
                heightMap[width, height] = 0;
            }
        }
    
        terrainData.SetHeights(0, 0, heightMap);

    }

    void OnDestroy() {
        if(flatternTerrain) {
            Debug.Log("Flatten Terrain is On");
            FlatternTerrain();
        }
    }

}