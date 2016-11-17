using UnityEngine;
using System.Collections;

// this thing, modifies the material of the recipient
public class isMatModifier : Mixin {

	public Material DestMat;
	public string OnModifyMatFinishedCB;

    public void ModifyMat()
    {
        // get all skinned mesh renderers, apply DestMat to all materials on each
        isEquipable[] ises = GetRecipient().GetComponentsInChildren<isEquipable>();
        foreach (isEquipable ise in ises)
        {
            Renderer[] smrs = ise.GetComponentsInChildren<Renderer>();
            foreach (Renderer smr in smrs)
            {
                smr.material = DestMat;
            }

            // just in case we need a hook when modifymat is done
            if (OnModifyMatFinishedCB != "")
                SendMessage(OnModifyMatFinishedCB);
        }
    }
		
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
