using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonRunner : MonoBehaviour {

    public GameObject tile;
    public GameObject character;
    public GameObject player;
    GameObject[] playerRoster;
    GameObject[] characters = new GameObject[3];
    private int playerCount;
    GameObject c;
    // Use this for initialization
    void Start()
    {

        bool gameDone = false;
        playerCount = 2;

        playerRoster = new GameObject[playerCount];
        float x;
        float z;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                x = 10 * i;
                z = 10 * j;
                GameObject t = (GameObject)Instantiate(tile, new Vector3(x, 0, z), Quaternion.identity);


            }


        }
        for (int i = 0; i < characters.Length; i++)
        {
            c = (GameObject)Instantiate(character, new Vector3(0, 0.5f, 10 * i), Quaternion.identity);
            characters[i] = c;
        }
        
    }
    private void Update()
    {
        

        for (int i = 0; i < characters.Length; i++)
        {
            Character ch = characters[i].GetComponent<Character>();
            if (ch.getMoves() == 0)
            {
                ch.ActiveStatus(false);
                Debug.Log("Out of Moves");
            }
            else
            {
                ch.ActiveStatus(true);
            }
        }

    }
}
