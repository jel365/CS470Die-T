using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    GameObject character;
    GameObject space;
    RaycastHit hit;
    GameObject activePlayer;
    GameObject activeSpace;
    Character c;
    Tile t;
    float s = 500;
    bool select;
    float x1;
    float x2;
    float z1;
    float z2;
    float offset;
    Vector3 dest;
    // Use this for initialization
    void Start () {
        
	}

    public void SetActivePlayer(GameObject g)
    {
        activePlayer = g;
        c = activePlayer.GetComponent<Character>();
    }

    public void SetActiveSpace(GameObject g)
    {
        if(activePlayer != null)
        {
            activeSpace = g;
            t = activeSpace.GetComponent<Tile>();
            select = true;
        }
        else
        {
            Debug.Log("No Player Selected");
        }
    }
	// Update is called once per frame
	void Update () {
		if(activePlayer != null && activeSpace != null)
        {
            
            x1 = activePlayer.transform.position.x;
            x2 = activeSpace.transform.position.x;
            z1 = activePlayer.transform.position.z;
            z2 = activeSpace.transform.position.z;
            if (Mathf.Abs(x1 - x2) <= 10 && Mathf.Abs(z1 - z2) <= 10)
            {
                if (select)
                {
                    dest = new Vector3(activeSpace.transform.position.x, activePlayer.transform.position.y, activeSpace.transform.position.z);
                    activePlayer.transform.position = Vector3.MoveTowards(activePlayer.transform.position, dest, s * Time.deltaTime);
                }
                if (activePlayer.transform.position == dest)
                {
                    select = false;
                   
                }
            }
            else
            {
                select = false;
            }
            
        }
	}
}
