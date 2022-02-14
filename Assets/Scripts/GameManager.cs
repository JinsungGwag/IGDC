using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject ghost;

    public int score;
    public int goal;

    public Transform left_top;
    public Transform right_down;

    private float minX, maxX, minZ, maxZ;

    // Start is called before the first frame update
    void Start()
    {
        minX = left_top.position.x;
        maxX = right_down.position.x;
        minZ = right_down.position.z;
        maxZ = left_top.position.z;
        
        Place(coin);
        Place(ghost);

        CheckClear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckClear()
    {
        if (score >= goal)
            Debug.Log("Clear");
    }

    public void Place(GameObject obj)
    {
        obj.transform.position = new Vector3(Random.Range(minX, maxX), obj.transform.position.y, Random.Range(minZ, maxZ));
    }
}