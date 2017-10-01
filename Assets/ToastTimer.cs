using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToastTimer : MonoBehaviour {

	public float burntTime = 120f;
	public float mildTime = 60f;
	public float coalTime = 180f;

	private GameObject timer;

	private float cTime = 0f;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		cTime += Time.deltaTime;
		timer.GetComponent<Text>().text = cTime.ToString();
	}
}
