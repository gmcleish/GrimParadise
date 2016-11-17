using UnityEngine;
using System.Collections;

// equip the item on the first available slot on the recipeint
// that means... attach the obj to the object that is a slot

public class isEquipable : Mixin
{

    public isEquipSlot.eSlot slotType;

    public void Equip()
    {
        // this is what we need to do
        // search through the hierarchy of the recipeint, find the slots of the type that matches tthe slottype in the item
        // attach the item in an open slot by setting it into the hierarhy with the hand as a parent
        GameObject recip = GetRecipient();
        Animator anim = recip.GetComponentInChildren<Animator>();

        

        if (recip != null)
        {
            isEquipSlot[] slots = recip.GetComponentsInChildren<isEquipSlot>();
            foreach (isEquipSlot ies in slots)
            {
                // if this slot's slottype matches the items slottype
                if (ies.slot == slotType)
                {
                    // if the slot is empty, insert it
                    if (ies.obj == null)
                    {
                        
                        Debug.Log("isEquipable::Equip() - ies.gameobject = " + ies.gameObject.name);
                        Debug.Log("isEquipable::Equip() - this.gameObject = " + this.gameObject.name);

                        if (ies.gameObject.name.Equals("LeftHand") && this.gameObject.name.Contains("Sword"))
                        {
                            anim.SetBool("HandednessOverride", true);
                        }

                        // insert it
                        ies.obj = this.gameObject;
                        this.gameObject.transform.parent = ies.gameObject.transform;
                        this.gameObject.transform.localPosition = Vector3.zero;
                        this.gameObject.transform.localRotation = Quaternion.identity;
                        Debug.Log("isEquipable::Equip() - item slot found, inserting!");
                        Debug.Log("isEquipable::Equip() - ies.gameobject = " + ies.gameObject.name);
                        Debug.Log("isEquipable::Equip() - this.gameObject = " + this.gameObject.name);

                        break;
                    }
                }
            }
        }
    }

    public void Dequip()
    {
        GameObject recip = GetRecipient();

        if (this.gameObject.GetComponent<hasAnimationOverride>())
        {
            hasAnimationOverride hao = this.gameObject.GetComponent<hasAnimationOverride>();
            if (recip.GetComponentInChildren<Animator>() != null)
            {
                recip.GetComponentInChildren<Animator>().runtimeAnimatorController = hao.GetOrigAnim();
            }
        }

        if (recip != null)
        {
            isEquipSlot[] slots = recip.GetComponentsInChildren<isEquipSlot>();
            foreach (isEquipSlot ies in slots)
            {
                // if this slot's slottype matches the items slottype
                if (ies.slot == slotType)
                {
                    // if the slot is empty, insert it
                    if (ies.obj != null)
                    {
                        if (ies.gameObject.name.Equals("LeftHand") && this.gameObject.name.Contains("Sword"))
                        {
                            Animator anim = recip.GetComponentInChildren<Animator>();

                            anim.SetBool("HandednessOverride", false);
                        }

                        Vector3 dropDist = 3.0f * recip.transform.forward;
                        Vector3 vDropPos = recip.transform.position + dropDist;
                        // insert it
                        ies.obj = null;
                        this.gameObject.transform.parent = null;
                        this.gameObject.transform.localPosition = vDropPos;
                        this.gameObject.transform.root.localRotation = Quaternion.identity;
                        Debug.Log("isEquipable::Dequip() - item found, removing!");

                        break;
                    }
                }
            }
        }
    }

    public void ToggleEquip()
    {
        bool isEquipped = false;

        GameObject recip = GetRecipient();
        if (recip != null)
        {
            isEquipSlot[] slots = recip.GetComponentsInChildren<isEquipSlot>();
            foreach (isEquipSlot ies in slots)
            {
                // if this slot's slottype matches the items slottype
                if (ies.slot == slotType)
                {
                    // if the slot is empty, insert it
                    if (ies.obj == this.gameObject)
                    {
                        isEquipped = true;
                        break;
                    }
                }
            }
        }

        if (isEquipped)
        {
            Dequip();
        }
        else
        {
            Equip();
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
