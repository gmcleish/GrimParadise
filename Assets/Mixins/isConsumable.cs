using UnityEngine;
using System.Collections;

public class isConsumable : Mixin {

	public void Consume()
	{
		// apply all buffs attached to this object, to the obj that touched us
		// we need to get [] all attributes on the recipient
		// we need to get [] all buffs attached on this consumable object
		// then if the names match... apply the delta increment!
		Data[] attribs = GetRecipient().GetComponents<Data>();
		Data[] buffs = this.gameObject.GetComponents<Data>();
		foreach (Data attrib in attribs)
		{
			foreach (Data buff in buffs)
			{
				// if the names match, add the buff to the attrib
				if (attrib.Name == buff.Name)
				{
					// they match, so apply the buff to the attrib
					IntData id = (attrib as IntData);
					if (id != null)
						id.IncData( (buff as IntData) ); // pass the intData into attrib for INC...
				}
			}
		}


		// then destroy self..
		Destroy(this.gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
