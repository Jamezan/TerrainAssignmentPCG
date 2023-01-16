using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField]
    public GameObject playerController; 

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerController, new Vector3(440f, 410f, Random.Range(0f, 1000f)), Quaternion.identity);
    }
}
