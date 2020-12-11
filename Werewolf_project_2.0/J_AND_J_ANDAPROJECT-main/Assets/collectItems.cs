using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;
//using System.Diagnostics;

public class collectItems : MonoBehaviour
{
	public bool part1collected;
	public bool part2collected;
	public bool part3collected;

	void start()
    {
		part1collected = false;
		part2collected = false;
		part3collected = false;


	}





	public GameObject item1;
	public GameObject item2;
	public GameObject item3;


	public Text check1;
	public Text check2;
	public Text check3;
	public Text wincase;
	public Text repair;
	//here we will destroy the game object the script is attached to if it collides with the player, as long as the tag "Player" has been assigned to the player.




	void OnTriggerEnter(Collider grab)
	{

		if (grab.gameObject.tag=="part1")
		{
			Debug.Log("test1");
			check1.text = "Got the first part";
			part1collected = true;

		}

		if (grab.gameObject.tag == "part2")
		{
			Debug.Log("test2");
			check2.text = "Got the second part";
			part2collected = true;
		}
		if (grab.gameObject.tag == "part3")
		{
			Debug.Log("test3");
			check3.text = "Got the third part";
			part3collected = true;
		}



		if(part1collected == true && part2collected == true && part2collected == true)
        {
			wincase.text = "Got all the parts. Time to leave!";
        }

		if (grab.gameObject.tag == "RiverBoatFreeFinished1" && part1collected == true && part2collected == true && part2collected == true)
		{
			
			repair.text = "press R to repair";
			

		}




		//if (grab.gameObject.tag == "RiverBoatFreeFinished1" && part1collected == true && part2collected == true && part2collected == true && (Input.GetKeyDown(KeyCode.R)) )
		//{

			


		//}






	}











	void Update()
	{

		


	}





}
	 


	

