using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FruitSC : MonoBehaviour
{


	public static int fruits;
	public int FruitsToAdd;
	Text text;

	void Start (){
		text = GetComponent <Text> ();
		fruits = PlayerPrefs.GetInt ("fruits", fruits);
	}

	void Update(){

		if (fruits < 0)
			fruits = 0;
		text.text = " " + fruits;

	}





	public static void AddFruits (int FruitsToAdd)
	{
		fruits += FruitsToAdd;
		PlayerPrefs.SetInt ("fruits", FruitsToAdd);
		if (FruitsToAdd == null)
			fruits = 0;
		if (fruits == 20) {
			SceneManager.LoadScene ("Win");
		}
	}
	public static void Reset (){
		fruits = 0;
	}
   
}

		
