using UnityEngine;
using System.Collections;

public class TileSelection : MonoBehaviour {

	MeshRenderer m;
	Color selected;
	Color old;
	public GameObject play;
    float s = 500;
	bool select;
	float x1;
	float x2;
	float z1;
	float z2;
    Vector3 dest;

	// Use this for initialization
	void Start () {
		m = GetComponent<MeshRenderer>();
		selected = Color.red;
		old = m.material.color;
	}
	
	void OnMouseOver(){
		m.material.color = selected;

		if (Input.GetMouseButtonDown (0)) 
		{
			select = true;
		}

	}

	void OnMouseExit(){
		
		m.material.color = old;
	}

	void Update()
	{
		x1 = play.transform.position.x;
		x2 = transform.position.x;
		z1 = play.transform.position.z;
		z2 = transform.position.z;
		if (Mathf.Abs(x1 - x2) <= 10 && Mathf.Abs(z1 - z2) <= 10) {
			if (select) {
                dest = new Vector3(transform.position.x, play.transform.position.y, transform.position.z);
				play.transform.position = Vector3.MoveTowards (play.transform.position, dest, s * Time.deltaTime);
			}
			if (play.transform.position == dest) {
				select = false;
			}
		} else {
			select = false;
		}
	}
}
