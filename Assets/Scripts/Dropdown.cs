using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour {
	public Sprite[] attelaMasivs;
	public GameObject attelaTuretajs;


	public void alexsteveChange(int skaitlis){
		if (skaitlis == 0) {
			attelaTuretajs.GetComponent<Image> ().sprite = attelaMasivs [0];
		} else if (skaitlis == 1) {
			attelaTuretajs.GetComponent<Image> ().sprite = attelaMasivs [1];
		}

	}
}
