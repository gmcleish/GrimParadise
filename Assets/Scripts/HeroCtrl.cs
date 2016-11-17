using UnityEngine;
using System.Collections;

//
// This class is responsible for putting the hero under user control (ie: joysticks, keyboard etc)
//
public class HeroCtrl : MonoBehaviour {

	public Vector3 inputs;  // axis values will be stored here so we can see them change in the inspector
	public bool actionButton;

	public float rotSpeed; // so we can massage user input
	public float walkSpeed;
	private Animator anim;	// our animator component, with the animCtrl for the hero... but how to set this reference?

	private Vector3 vFwd;

	public void OnEnable()
	{
		anim = this.gameObject.GetComponentInChildren<Animator>();
	}

	public void HeroCtrlUpdate()
	{
		// get values from user input...and then apply them to the hero, in order to make the hero move!
		inputs.x = Input.GetAxis("Horizontal");
		inputs.z = Input.GetAxis("Vertical");
		actionButton = Input.GetButtonDown("Fire1");

		// apply axis values to move the character
		vFwd = Vector3.forward; //always 0,0,1 relative to our local coords
		this.gameObject.transform.Translate( walkSpeed * Time.deltaTime * inputs.z * vFwd );

		// apply rotation values based on user input, lets use horizontal axis from inputs.x
		this.gameObject.transform.Rotate( Vector3.up, Time.deltaTime * rotSpeed * inputs.x );

		// animate the skinned mesh for the knight/hero based on user input
		if (anim != null)
		{
			// pass axis data to the animator to drive the params
			anim.SetFloat("v", inputs.z);
			anim.SetFloat("h", inputs.x);

			if (actionButton == true)
            { 
				anim.SetTrigger("action");
            }
        }
	}

	public void HealthUpdate () 
	{
		float health;
		this.GetComponents<FloatData>();


	}

	// Update is called once per frame
	void Update () 
	{
	
		HeroCtrlUpdate();
	}

	// Use this for initialization
	void Start () 
	{

	}
}
