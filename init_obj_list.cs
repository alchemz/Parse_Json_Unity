using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
	//the properties A and B
	//A is int
	//B is string
	public int A { get; set;}
	public string B{ get; set; }
}
public class init_obj_list : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<Test> list1 = new List<Test> () {
			new Test(){A=1, B="Jessica"},
			new Test(){A=2, B="Mandy"}
		};

		List<Test> list2 = new List<Test> ();
		list2.Add (new Test () { A = 3, B = "Sarah" });
		list2.Add (new Test (){ A = 4, B = "Melanie" });

		Debug.Log (list1.Count);
		Debug.Log (list2.Count);
	}

}
