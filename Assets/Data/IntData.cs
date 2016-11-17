using UnityEngine;
using System.Collections;

public class IntData : Data {

	// make this private but inspectable (fix)
	public int data;	// p.o.d. that we are encapsulating

	public int GetData()
	{
		return data;
	}

	public void SetData(IntData id)
	{
		data = id.GetData();
	}

	public void SetData(int i)
	{
		data = i;
	}

	public void IncData(IntData id)
	{
		data += id.GetData();
	}

	public void IncData(int i)
	{
		data += i;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
