using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialize_List : MonoBehaviour {

	// use collection initializer
	void Start () {

		List<string> list1 = new List<string> () {
			"carrort",
			"fox",
			"explorer"
		};
		//use var keywaord with collection initializer
		var list2 = new List<string> () {
			"carrot",
			"fox",
			"explorer"
		};

		//Use new array as parameter
		string[] array={"carrot","fox", "explorer"};
		List<string> list3 = new List<string> (array);

		//use capacity in constructor and assign
		List<string> list4= new List<string>(3);
		list4.Add (null);
		list4.Add (null);
		list4.Add (null);
		list4 [0] = "carrot";
		list4 [1] = "fox";
		list4 [2] = "explorer";

		//use add method for each element
		List<string> list5= new List<string>();
		list5.Add("carrot");
		list5.Add ("fox");
		list5.Add ("explorer");

		Debug.Log ("List1:" + list1.Count + list1[0]);
		Debug.Log ("List2:" + list2.Count+ list2[0]);
		Debug.Log ("List3:" + list3.Count+ list3[0]);
		Debug.Log ("List4:" + list4.Count+list4[0]);
		Debug.Log ("List5:" + list5.Count+list5[0]);
		}
	
	// Update is called once per frame
	void Update () {
		
	}
}
