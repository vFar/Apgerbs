using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour {
	public Sprite[] atteli;
	public GameObject platumsSlider1;
	public GameObject garumsSlider1;
	public GameObject attelaturetajs;

	public float currentValueX, currentValueY;

	public void sliderSizeX(){
		currentValueX = platumsSlider1.GetComponent<Slider>().value;
		currentValueY = garumsSlider1.GetComponent<Slider> ().value;
		attelaturetajs.GetComponent<RectTransform>().sizeDelta = new Vector2 (100F * currentValueX, 180F*currentValueY);
	}

	public void sliderSizeY(){
		currentValueX = platumsSlider1.GetComponent<Slider>().value;
		currentValueY = garumsSlider1.GetComponent<Slider>().value;
		attelaturetajs.GetComponent<RectTransform>().sizeDelta = new Vector2 (100F*currentValueX, 180F*currentValueY);
			
	}
}
