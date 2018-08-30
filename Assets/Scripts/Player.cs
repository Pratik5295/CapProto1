using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
    public enum States
    {
        Idle,Attack,Jump,Hit,Death,Switch
    }

    public States CurrentState = States.Idle;
	void Start () {

		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Z)){
            
            anim.SetTrigger ("Attack");
           
		}

        if (Input.GetKeyDown(KeyCode.X))
        {
            //Throw the weapon

        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            CurrentState = States.Attack;
           
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
           
            CurrentState = States.Idle;
        }
		
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Enemy")
        {
            if(CurrentState == States.Attack)
            {
                Debug.Log("Enemy hit : " + collision.gameObject.name + " takes damage from player");
            }
        }
      
    }
}
