using UnityEngine;
using System.Collections;

public class SphereTrigger : MonoBehaviour {

	SphereTrigger sphereWorldOneObj;
	SphereTrigger sphereWorldTwoObj;


	// Use this for initialization
	void Start () {
		Debug.Log("Sphere Trigger Script");
		sphereWorldOneObj = GameObject.Find("sphereWorldOne").GetComponent<SphereTrigger>();
		sphereWorldTwoObj = GameObject.Find("sphereWorldTwo").GetComponent<SphereTrigger>();
		//Debug.Log("What is this: " + sphereWorldOneObj);
		//sphereWorldOne = GameObject.Find("sphereWorldOne");
		//Debug.Log("sphereWorldOne: " + sphereWorldOne);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider objectThatWasHit)
	{

		//Debug.Log("Shit went down. The Collision object is: " + objectThatWasHit + this);
		if (this == sphereWorldOneObj) 
		{
			Debug.Log("I'm in Sphere World One "  + this);

		}

		if (this == sphereWorldTwoObj) 
		{
			Debug.Log("I'm in Sphere World Two "  + this);
			//GUI.Label(new Rect(35, 60, 150, 100), "Location: 2");
			if(!audio.isPlaying)
			{
				audio.Play();
			}
		}
	}

}
