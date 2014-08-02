using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public bool direccionY;
	public float Velocidad;
	private Vector2 direccion;
	void Start () {
		direccion = Vector2.right * (direccionY ? 1 : -1);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.rigidbody2D.velocity = direccion*Velocidad;
	}
}
