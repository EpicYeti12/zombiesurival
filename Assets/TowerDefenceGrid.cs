using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDefenceGrid : MonoBehaviour {

    public GameObject prefab;
    public int size;
    public float spacing;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Vector3 pos = new Vector3(i * spacing, 0, j * spacing);
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
