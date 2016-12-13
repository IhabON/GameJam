using UnityEngine;
using System.Collections;

public class Suivre : MonoBehaviour {
    public Transform Player;
	// Use this for initialization
	void Start () {
        Debug.Log("caméra suit");
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Player.position.x, Player.position.y / 2, -10);	
	}
}
