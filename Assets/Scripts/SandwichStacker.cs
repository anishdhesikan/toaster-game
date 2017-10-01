using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandwichStacker : MonoBehaviour {

	public InputField inputField;
	public Text stackText;

	private List<string> myStack;

	void Awake () {
		myStack = new List<string>();
		inputField.onEndEdit.AddListener ((value) => SubmitEntry (inputField.text));
		AddToStack ("Bread");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AddToStack (string ingredient) {
		myStack.Add (ingredient);
		UpdateStackText ();
	}

	void SubmitEntry (string value) {
		AddToStack (value);
		ClearTextInputField ();

		if (value.ToLower () == "bread") {
			OnBreadSubmitted ();
		} else {
			inputField.Select ();
			inputField.ActivateInputField ();
		}
	}

	void UpdateStackText () {
		string newText = "";
		for (int i = myStack.Count - 1; i >= 0; i--) {
			string curString = myStack [i];
			newText += curString;
			if (i > 0) {
				newText += "\n";
			}
		}

		stackText.text = newText;
	}

	void ClearTextInputField () {
		inputField.text = "";
	}

	public void ClearStack () {
		myStack.Clear ();
		AddToStack ("Bread");
		UpdateStackText ();
	}

	void OnBreadSubmitted () {
		// Game ends
		Debug.Log ("Game Ended");
		inputField.interactable = false;
	}
}
