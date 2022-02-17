using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChaseTarget(Vector3 position)
    {
        transform.LookAt(position);
        transform.Translate(Vector3.forward * speed);
    }
}