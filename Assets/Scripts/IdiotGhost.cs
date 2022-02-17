using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdiotGhost : Ghost
{
    public Transform left_top;
    public Transform right_down;

    private float minX, maxX, minZ, maxZ;
    private Vector3 random;

    // Start is called before the first frame update
    public void Init()
    {
        minX = left_top.position.x;
        maxX = right_down.position.x;
        minZ = right_down.position.z;
        maxZ = left_top.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        random.x = Random.Range(minX, maxX);
        random.y = transform.position.y;
        random.z = Random.Range(minZ, maxZ);

        ChaseTarget(random);
    }
}
