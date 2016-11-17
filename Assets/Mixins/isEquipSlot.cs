using UnityEngine;
using System.Collections;

public class isEquipSlot : Mixin {

	public GameObject obj; // this is the actual reference to the slotted object.
	public enum eSlot
	{
		eInvalid = -1,
		eNone = 0,
		eHand = 1,
		eHead = 2,
		eChest = 3,
		eFoot = 4
	}

	public eSlot slot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
