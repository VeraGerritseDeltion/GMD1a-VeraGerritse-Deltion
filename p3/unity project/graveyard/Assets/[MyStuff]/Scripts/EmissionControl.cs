using UnityEngine;
using System.Collections;

public class EmissionControl : MonoBehaviour 
{
	public Renderer myRenderer;
	public Material material;
	public AnimationCurve animationCurve;
	public float frequency = 1.0f;
	public float phaseShift = 0.0f;
	public bool updateGI = false;

	private float emissionValue;
	Color color;

	// Use this for initialization
	void Start () 
	{
		myRenderer = GetComponent<Renderer>();
		material = GetComponent<Renderer>().material;
		color = material.GetColor("_EmissionColor");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		emissionValue = animationCurve.Evaluate(Time.time * frequency + phaseShift);
		//Debug.Log(emissionValue);
		material.SetColor("_EmissionColor", (color * emissionValue));


		if(updateGI)
		{
			//DynamicGI.SetEmissive(myRenderer, (color * emissionValue));
			DynamicGI.UpdateMaterials(myRenderer);
		}

	}
}
