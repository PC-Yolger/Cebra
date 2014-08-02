using UnityEngine;
using System.Collections;

public class GeneradorEsc : MonoBehaviour {
	public float tiempoAparicion, destroyTime;
	private float tiempo;
	public GameObject[] Generar;

	void Start()
	{
		tiempo = tiempoAparicion;
	}

	void Update()
	{
		if(tiempo<0)
		{
			GameObject Obj = Instantiate (Generar[Random.Range(0,Generar.Length)],this.transform.position,Quaternion.identity) as GameObject;
			Destroy (Obj,destroyTime);
			tiempo=tiempoAparicion;
		}
		else
		{
			tiempo-=Time.deltaTime;
		}

	}
}
