using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject chase;
    public GameObject idiot;

    public int coinCount;
    public int chaseCount;
    public int idiotCount;

    public int score;
    public int goal;

    public Transform player;
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

        Make(coin, coinCount);
        MakeChase(chase, chaseCount);
        MakeIdiot(idiot, idiotCount);
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

    public void RaiseScore(int number)
    {
        score += number;
    }

    public void Place(GameObject obj)
    {
        obj.transform.position = new Vector3(Random.Range(minX, maxX), obj.transform.position.y, Random.Range(minZ, maxZ));
    }

    public void Make(GameObject obj, int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject newObj = Instantiate(obj);
            Place(newObj);
        }
    }

    public void MakeChase(GameObject obj, int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject newObj = Instantiate(obj);

            ChaseGhost chaseGhost = newObj.GetComponent<ChaseGhost>();
            chaseGhost.player = player;
            
            Place(newObj);
        }
    }

    public void MakeIdiot(GameObject obj, int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject newObj = Instantiate(obj);

            IdiotGhost idiotGhost = newObj.GetComponent<IdiotGhost>();
            idiotGhost.left_top = left_top;
            idiotGhost.right_down = right_down;
            idiotGhost.Init();

            Place(newObj);
        }
    }
}