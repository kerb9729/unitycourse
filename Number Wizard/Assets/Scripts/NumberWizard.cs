using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
	
		print ("Welcome to Number Wizard");
		print ("Pick a number, but don't tell me what it is.");
		

		print ("The highest number you can  pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow\t: Higher");
		print ("Down arrow\t: Lower");
		print ("Return\t: Equal");

		//max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("UpArrow key was pressed");
			min = guess + 1;
			guess = (max + min)/2;
			print ("Is it higher, lower, or equal to " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("DownArrow key was pressed");
			max = guess - 1;
			guess = (max + min)/2;
			print ("Is it higher, lower, or equal to " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!!");
			Application.Quit();
		}
	}
}
// There's not a way to keep the user honest without storing each min and max.
// If the number is 251 and the user goes :up, down , down (down repeatedly) then
// the game will get stuck at 250 (even though 250 was a guess)
