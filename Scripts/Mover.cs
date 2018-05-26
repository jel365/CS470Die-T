﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    GameObject character;
    GameObject space;
    RaycastHit hit;
    GameObject activePlayer;
    GameObject activeSpace;
    Character c;
    Tiles t;
    float s = 50;
    bool select;
    float x1;
    float x2;
    float z1;
    float z2;
    float offset;
    Vector3 dest;
   
    // Use this for initialization
    void Start()
    {
        select = false;
        
    }

    

    public void SetActivePlayer(GameObject g)
    {
        
        if (!select)
        {
            activePlayer = g;
            c = activePlayer.GetComponent<Character>();
            if(!c.GetActive())
            {
                Debug.Log("This character can't move");
                activePlayer = null;
            }
        }
    }

    public void SetActiveSpace(GameObject g)
    {
        if (!select)
        {
            if (activePlayer != null)
            {
                activeSpace = g;
                t = activeSpace.GetComponent<Tiles>();
                select = true;
                Character ch = activePlayer.GetComponent<Character>();
                if (ch.getMoves() != 0)
                {
                    ch.decMoves();
                }
                
            }
            else
            {
                Debug.Log("No Player Selected");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

       
        

        
        if (activePlayer != null && activeSpace != null)
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
                    activePlayer = null;
                    activeSpace = null;
                    

                }
            }
            else
            {
                select = false;
            }

        }
    }
}