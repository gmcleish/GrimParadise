using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class isClickable : Mixin
{

    public List<string> OnClickCBs; // what method to call when a touch happens
    public GameObject Recipient;  // only respond to object that have this aspect.

    public void OnMouseDown()
    {
        // if something touched us that we want to respond to
        if (Recipient != null)
        {
            // send the response message to that gameobject
            // todo fix hack, asap dhdh
            isConsumable isc = this.gameObject.GetComponent<isConsumable>();
            if (isc != null)
                isc.SetRecipient(Recipient); // tell the consumable who to send msg to..the player in this specific case!

            isMatModifier ismm = this.gameObject.GetComponent<isMatModifier>();
            if (ismm != null)
                ismm.SetRecipient(Recipient);

            isEquipable iseq = this.gameObject.GetComponent<isEquipable>();
            if (iseq != null)
                iseq.SetRecipient(Recipient); // fix todo: this needs to be streamlined dhdh

            isStoreable iss = this.gameObject.GetComponent<isStoreable>();
            if (iss != null)
                iss.SetRecipient(Recipient);

            foreach (string cbString in OnClickCBs)
            {
                if (cbString != "")
                    SendMessage(cbString);
            }

            Debug.Log("isClickable - I was clicked!");
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
