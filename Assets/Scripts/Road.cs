using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        CreateRoad();
        CreateRoad2();
        CreateRoad3();
    }

    private void CreateRoad() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Path";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(0, 400f, 30f);
        road.transform.Rotate(90, 0, 0, Space.Self);
        road.transform.localScale = new Vector3(50f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);
    }

    private void CreateRoad2() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Path2";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(0f, 400f, 940f);
        road.transform.Rotate(90, 0, 0, Space.Self);
        road.transform.localScale = new Vector3(50f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);
    }

    private void CreateRoad3() {

        int roadLengthSize = 10;
        int roadHeightSize = 10;
        Vector3 initialisePosition = new Vector3(0,0,10f);

        GameObject road = new GameObject();
        road.name = "Path3";
        road.transform.parent = this.transform;
        road.AddComponent<Wall>();
        road.GetComponent<Wall>().initialiseWall(roadLengthSize, roadHeightSize, initialisePosition);
        
        road.transform.localPosition = new Vector3(450f, 400f, 60f);
        road.transform.Rotate(90, 0, 90, Space.Self);
        road.transform.localScale = new Vector3(50f, 1f, 1f);
        BoxCollider collider = road.AddComponent<BoxCollider>();
        collider.center = new Vector3(9.022366f, 9.022366f, 11f);
        collider.size = new Vector3(20.25608f, 21.9303f, 3.985396f);
    }
}
