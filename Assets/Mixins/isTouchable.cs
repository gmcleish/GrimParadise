using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class isTouchable : Mixin {

	public List<string> OnTouchCBs;	// what method to call when a touch happens
	public List<string> touchType;	// only respond to object that have this aspect.

	public void OnCollisionEnter(Collision col)
	{
		// if something touched us that we want to respond to
		foreach( string s in touchType)
		{
			if (col.gameObject.GetComponent(s) != null)
			{
				// send the response message to that gameobject
				// todo fix hack, asap dhdh
				isConsumable isc = this.gameObject.GetComponent<isConsumable>();
				if (isc != null)
					isc.SetRecipient(col.gameObject); // tell the consumable who to send msg to..the player in this specific case!

				isMatModifier ismm = this.gameObject.GetComponent<isMatModifier>();
				if (ismm != null)
					ismm.SetRecipient(col.gameObject);

				isEquipable iseq = this.gameObject.GetComponent<isEquipable>();
				if (iseq != null)
					iseq.SetRecipient(col.gameObject); // fix todo: this needs to be streamlined dhdh

                hasAnimationOverride hao = this.gameObject.GetComponent<hasAnimationOverride>();
                if (hao != null)
                {
                    hao.SetRecipient(col.gameObject);
                    hao.OverrideAnimator();
                }

                isSpawner iss = this.gameObject.GetComponent<isSpawner>();
                if (iss != null)
                    iss.SetRecipient(col.gameObject);
                

                //isEnchantable isench = this.gameObject.GetComponent<isEnchantable>();
                //if (isench != null)
                //    isench.SetRecipient(col.gameObject);

                foreach (string cbString in OnTouchCBs)
				{
					if (cbString != "")	
						SendMessage(cbString);
				}
			}
		}
	}

	public void DebugMsg()
	{
		Debug.Log("I was touched...");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
