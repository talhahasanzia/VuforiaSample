using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    public GameObject player;

    Vector3 Pos;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Pos = Vector3.Lerp(gameObject.transform.position, player.transform.position, Time.deltaTime);

        transform.position = new Vector3(Pos.x, 1, Pos.z);

	}
}
