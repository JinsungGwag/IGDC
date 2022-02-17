using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseGhost : Ghost
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChaseTarget(player.position);   
    }
}
