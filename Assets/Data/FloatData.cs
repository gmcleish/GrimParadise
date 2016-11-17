using UnityEngine;
using System.Collections;

public class FloatData : Data {

	// make this private but inspectable (fix)
	public double data;	// p.o.d. that we are encapsulating

	public double GetData()
	{
		return data;
	}

	public void SetData(FloatData id)
	{
		data = id.GetData();
	}

	public void SetData(double i)
	{
		data = i;
	}

	public void IncData(FloatData id)
	{
		data += id.GetData();
	}

	public void IncData(double i)
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
