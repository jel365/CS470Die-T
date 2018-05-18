using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    MeshRenderer m;
    Color selected;
    Color old;
    Mover master;
    public GameObject control;
    void Start()
    {
        m = GetComponent<MeshRenderer>();
        m.material.color = Color.black;
        selected = Color.blue;
        old = m.material.color;

        master = control.GetComponent<Mover>();
    }

    void OnMouseOver()
    {
        m.material.color = selected;

        if (Input.GetMouseButtonDown(0))
        {
            master.SetActivePlayer(gameObject);
        }

    }

    void OnMouseExit()
    {

        m.material.color = old;
    }
}
