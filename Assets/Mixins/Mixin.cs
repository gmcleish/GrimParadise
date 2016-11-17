using UnityEngine;
using System.Collections;

public class Mixin : MonoBehaviour {

	public string Name;	// a way to identify this mixin directly
	private GameObject recipient;	// the obj that receives the sendMessage from the parent mixin

	public void SetRecipient(GameObject rec)
	{
		recipient = rec;
	}

	public GameObject GetRecipient()
	{
		return recipient;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
