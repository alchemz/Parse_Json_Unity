using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class RootObject
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<int> Stats { get; set; }
}


public class RootObject_
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<List<int>> Stats { get; set; }
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

	public	int x_ ;
	public	int y_;
	public	int z_ ;

	private void Initialize (CsReadJson parent) {
		mesh = parent.mesh;
		material = parent.material;
		maxDepth = parent.maxDepth;
		depth = parent.depth + 1;
		transform.parent = parent.transform;
	}

	private IEnumerator CreateChildren () {
			yield return new WaitForSeconds(0.5f);
			new GameObject("Fractal Child").AddComponent<CsReadJson>().
			Initialize(this);
	}

    void Start()
    {

        jsonString_ = File.ReadAllText(Application.dataPath + "/Resources/test2.json");
        RootObject_ stats_ = JsonMapper.ToObject<RootObject_>(jsonString_);
       
		x_ = stats_.Stats [0][0];
		y_ = stats_.Stats [0][1];
		z_ = stats_.Stats [0][2];
	
		gameObject.AddComponent<MeshFilter>().mesh = mesh;
		gameObject.AddComponent<MeshRenderer>().material = material;

		if (depth < maxDepth) {
			StartCoroutine(CreateChildren());
		}

		transform.position = new Vector3 (x_, y_, z_);
      }

}


