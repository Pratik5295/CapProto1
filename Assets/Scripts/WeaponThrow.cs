using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponThrow : MonoBehaviour {

	// Use this for initialization

        //play with x value

    public enum State
    {
        Idle,Throw,Return
    }

    public State Current;


	void Start () {

        Current = State.Idle;
	}
	
	// Update is called once per frame
	void Update () {
		

        if(Current == State.Throw)
        {
            this.transform.Translate(new Vector2(2 * Time.deltaTime, 0));
        }

        if(Current == State.Return)
        {
           this.transform.position =  this.transform.parent.position;
        }
	}
}
