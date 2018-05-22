using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    MeshRenderer m;
    private Character[] characterRoster;
    private int playerNumber;


    public Player(int playerNumber, Character[]characterRoster)
    {
        this.playerNumber = playerNumber;
        this.characterRoster = characterRoster;
    }

    public void Activate()
    {
        for(int i = 0; i < characterRoster.Length; i++)
        {
            characterRoster[i].SetActive(true);
        }
    }

    public void DeActivate()
    {
        for (int i = 0; i < characterRoster.Length; i++)
        {
            characterRoster[i].SetActive(false);
        }
    }
	// Use this for initialization
	void Start () {

     m = GetComponent<MeshRenderer>();
        m.material.color = Color.black;
    
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
