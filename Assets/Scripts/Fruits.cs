using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour {

	public int FruitsToAdd;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerMovement> () == null)
			return;
		FruitSC.AddFruits (FruitsToAdd);
		Destroy (gameObject);
		
	}

}
