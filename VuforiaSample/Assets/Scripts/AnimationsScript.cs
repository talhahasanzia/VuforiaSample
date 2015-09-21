using UnityEngine;
using System.Collections;


public class AnimationsScript : MonoBehaviour {

   
    Animator anim;
    public GameObject obj;

   
	// Use this for initialization
	void Start () {

        
        anim = gameObject.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Bounce.Jump)
        {

            anim.SetBool("Jump", true);
            Bounce.Jump = false;

        }
        else
        {

            anim.SetBool("Jump", false);
        
        
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Shoot", true);


        }
        else
        {

            anim.SetBool("Shoot", false);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow)  )
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)  )
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow)  )
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);


        }
        if (Input.GetKeyDown(KeyCode.DownArrow)  )
        {

            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
	}
}
