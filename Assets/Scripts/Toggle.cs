using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

	public GameObject Cepures;
	public GameObject Torso;
	public GameObject Bikses;
	public GameObject Kurpes;

	public GameObject Wolf;
	public GameObject Sword;
	public GameObject Crossbow;

	public void showCepures(bool variable){
		Cepures.SetActive (variable);
	}

	public void showTorso(bool variable){
		Torso.SetActive (variable);
	}

	public void showBikses(bool variable){
		Bikses.SetActive (variable);
	}

	public void showKurpes(bool variable){
		Kurpes.SetActive (variable);
	}




	public void showWolf(bool variable){
		Wolf.SetActive (variable);
	}


	public void showWeapons(bool variable){
		Sword.SetActive (variable);
		Crossbow.SetActive (variable);
	}
	
}
