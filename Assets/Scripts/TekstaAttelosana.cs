using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaAttelosana : MonoBehaviour {
	public string text;
	public string age;

	public GameObject VecumsInput;
	public GameObject VardaInput;
	public GameObject MCText;

	public void TextAndAgeActions(){
		text = VardaInput.GetComponent<Text>().text;
		age = VecumsInput.GetComponent<Text> ().text;

		MCText.GetComponent<Text> ().text = "Minecraft téla várds ir " + text + " un tá vecums - " + age + " gadi!";
	}
}
