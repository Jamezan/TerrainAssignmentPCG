using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField]
    private int wallLengthSize = 10; //number of cubes

    [SerializeField]
    private int wallHeightSize = 5; // number of cubes.

    [SerializeField]
    private Vector3 initialisePosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        /*initialiseWall(wallLengthSize, wallHeightSize, initialisePosition);
        initialiseWall(4, 6, new Vector3(3f, 9f, 20f));*/
    }

    public void initialiseWall(int newWallLengthSize, int newWallHeightSize, Vector3 newInitialisePosition){
        wallLengthSize = newWallLengthSize;
        wallHeightSize = newWallHeightSize;
        initialisePosition = newInitialisePosition;
        CreateWall();
    }


    private void CreateWall(){

        Vector3 nextPosition = initialisePosition;

        float cubeHeight = 0;

        for(int j = 0; j < wallHeightSize; j++){
            for(int i = 0; i < wallLengthSize; i++)
            {

                GameObject cube = new GameObject();
                cube.transform.Rotate(0f, 90f, 0f);
                cube.name = "Cube " + j + "-" + i;
                cube.AddComponent<Cube>();
                cube.transform.position = nextPosition;
                cube.transform.parent = this.transform;

                nextPosition.x = cube.GetComponent<Cube>().CubeSize().x + nextPosition.x;
                cubeHeight = cube.GetComponent<Cube>().CubeSize().y;
            }
            nextPosition.y = cubeHeight + nextPosition.y;
            nextPosition.x = 0;
        }

    }
}
