using UnityEngine;
using System.Collections;

public class MoveVertocalScript : MonoBehaviour {

	public float speed;
	public float weigth;
	public float frequency;
	public float amplitude;

	//Private
	Transform thisTransform;

	// Use this for initialization
	void Start()
	{
		thisTransform = transform;
	}

	// Update is called once per frame
	void Update()
	{
		thisTransform.position += (WaveY(weigth, frequency, amplitude) * Time.deltaTime) * speed;
	}

	public Vector3 WaveY(float weight, float frequency, float amplitude)
	{
		float offsetY = Mathf.Sin(Time.time * frequency) * amplitude;

		Vector3 direction = new Vector3(0.0f, offsetY, 0.0f);
		return direction * weight;
	}
}
