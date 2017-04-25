using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class RootObject
{
	public string Name { get; set; }
	public int Level { get; set; }
	public List<double> Stats { get; set; }
}


public class RootObject_
{
	public string Name { get; set; }
	public int Level { get; set; }
	public List<List<double>> Stats { get; set; }
}


public class CsReadJson : MonoBehaviour {


	private string jsonString;
	private JsonData cmdData;


	private string jsonString_;
	private JsonData cmdData_;
	// Use this for initialization


	public Mesh mesh;
	public Material material;
	public int maxDepth;
	private int depth;

	private	double[][] x_ ;
	private	double[][] y_;
	private	double[][] z_ ;


	void Start()
	{

		jsonString_ = File.ReadAllText(Application.dataPath + "/Resources/demo.json");
		RootObject_ stats_ = JsonMapper.ToObject<RootObject_>(jsonString_);

		for (int i = 0; i < stats_.Stats.Count; i++){
				
		//	gameObject.AddComponent<MeshFilter>().mesh = mesh;
		//	gameObject.AddComponent<MeshRenderer>().material = material;
			if (depth < maxDepth) {
				GameObject sphere =	GameObject.CreatePrimitive (PrimitiveType.Sphere);
				sphere.transform.position = new Vector3 ((float)stats_.Stats [i] [0], (float)stats_.Stats[i][1], (float)stats_.Stats [i] [2]);
				sphere.GetComponent<MeshFilter> ().mesh = mesh;
				sphere.GetComponent<MeshRenderer> ().material = material;
				sphere.transform.localScale = new Vector3(0.015F, 0.015F, 0.015F);
			}


		}


	}

}

