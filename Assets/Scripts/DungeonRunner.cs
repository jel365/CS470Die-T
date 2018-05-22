using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonRunner : MonoBehaviour {

    public GameObject Tile;

	// Use this for initialization
	void Start () {
        float x;
        float z;
		for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x = 10 * i;
                z = 10 * j;
                GameObject t = (GameObject)Instantiate(Tile, new Vector3 (x, 0, z), Quaternion.identity);
               
            }
        }
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
