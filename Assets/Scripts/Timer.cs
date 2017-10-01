using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class Timer : MonoBehaviour {

	[Range(0, 360)]
	public float initialSec = 180;

	private Text myText;
	private float secRemaining;

	// Use this for initialization
	void Awake () {
		secRemaining = initialSec;
		myText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		TimeSpan timespan = TimeSpan.FromSeconds(secRemaining);
		myText.text = string.Format ("{0:D2}:{1:D2}", timespan.Minutes, timespan.Seconds);
	}
}
