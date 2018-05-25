using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    MeshRenderer m;
    private GameObject[] characterRoster = new GameObject[3];
    private int playerNumber;


   

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

    
        
    }

    public void setCharacter(GameObject []c)
    {
        characterRoster = c;
    }

    public GameObject[] getCharacter()
    {
        return characterRoster;
    }

    public void setNum(int n)
    {
        playerNumber = n;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
