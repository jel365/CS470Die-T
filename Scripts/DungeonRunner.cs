using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonRunner : MonoBehaviour {

    public GameObject tile;
    public GameObject character;
    public GameObject player;
    GameObject[] playerRoster;
   
    private int playerCount;
	// Use this for initialization
	void Start () {
        playerCount = 2;
        
        playerRoster = new GameObject[playerCount];
        float x;
        float z;
		for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x = 10 * i;
                z = 10 * j;
                GameObject t = (GameObject)Instantiate(tile, new Vector3 (x, 0, z), Quaternion.identity);
                

            }
            
            
        }

        playerFill();
       
        

	}

    public void playerFill()
    {
        
        
        for(int i = 0; i < 2; i++)
        {

            GameObject p = player;
            playerRoster[i] = player;
            GameObject[] characters = new GameObject[3];
            Player pl = playerRoster[i].GetComponent<Player>();
            pl.setNum(i + 1);
            for (int j = 0; j < 3; j++)
            {
                
                GameObject c = (GameObject)Instantiate(character, new Vector3((20 * i), 0.5f, (10 * j)), Quaternion.identity);
                Character ch = c.GetComponent<Character>();
                ch.SetNum(i + 1);
                characters[j] = c;

            }
            pl.setCharacter(characters);
        }

        Player test = playerRoster[1].GetComponent<Player>();
        Destroy(test.getCharacter()[0]);
        Destroy(test.getCharacter()[2]);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
