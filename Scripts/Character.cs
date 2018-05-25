using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    MeshRenderer m;
    Color selected;
    Color old;
    Mover master;
   
    private int playerNum;
    public GameObject control;
    bool active;
    void Start()
    {
       
        m = GetComponent<MeshRenderer>();
        m.material.color = Color.black;
        selected = Color.blue;
        old = m.material.color;

        master = Camera.main.GetComponent<Mover>();
    }

    void OnMouseOver()
    {
        m.material.color = selected;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(playerNum);
            if (GetActive())
            {
                master.SetActivePlayer(gameObject);
            }
            else
            {
                Debug.Log("You can't interact with this character right now");
            }
        }

    }

    public void SetActive(bool a)
    {
        active = a;
    }

    public bool GetActive()
    {
        return active;
    }
    void OnMouseExit()
    {

        m.material.color = old;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GetActive())
        {
            SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && GetActive())
            {
                SetActive(false);
            }
    }

    public void SetNum(int n)
    {
        playerNum = n;
    }
}
