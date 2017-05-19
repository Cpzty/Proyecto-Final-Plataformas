using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

	Animator anim;
	public GameObject thePlayer;

	// Use this for initialization
	void Start () {

		anim = gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		Bounce bouncy = thePlayer.GetComponent<Bounce> ();
		if (bouncy.justJump == true) {
			anim.SetBool ("Jump", true);

		} else {
			anim.SetBool ("Jump", false);
		}

	}
}
