﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIStory : MonoBehaviour 
{
	public Text bottomText;
	public Text storyText;

	// Use this for initialization
	void Start () 
	{
		storyText = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{	
		

	}
}
