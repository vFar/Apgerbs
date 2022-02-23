using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioSource Bark;
	public AudioClip Wolf_Bark;

	public AudioSource Bow;
	public AudioClip Bow_shot;

	public AudioSource Sword;
	public AudioClip Sword_slash;

	public void WolfOn(){
		Bark.PlayOneShot (Wolf_Bark);
	}

	public void WolfOff(){
		Bark.Stop ();
	}


	public void SwordOn(){
		Sword.PlayOneShot (Sword_slash);
	}

	public void SwordOff(){
		Sword.Stop ();
	}


	public void BowOn(){
		Bow.PlayOneShot (Bow_shot);
	}

	public void BowOff(){
		Bow.Stop ();
	}





}
