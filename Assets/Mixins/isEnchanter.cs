using UnityEngine;
using System.Collections;

public class isEnchanter : Mixin
{
    public AnimatorOverrideController aoc;
    public GameObject projectile;

    public void Enchant()
    {
        //GameObject recip = GetRecipient();

        //isEnchantable isench = recip.GetComponentInChildren<isEnchantable>();
        //isench.gameObject.AddComponent<isSpawner>();

        //isSpawner issp = recip.GetComponentInChildren<isSpawner>();
        //issp.obj = projectile;

        //hasAnimationOverride hao = isench.gameObject.GetComponent<hasAnimationOverride>();
        //hao.SetOverrideAnim(aoc);
        //hao.OverrideAnimator();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
