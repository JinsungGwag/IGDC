using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
    }

    private void OnCollisionEnter(Collision collider)
    {
        switch(collider.transform.tag)
        {
            case "Coin":
                manager.RaiseScore(1);
                break;

            case "Ghost":
                Debug.Log("Over");
                speed = 0;
                break;

            default:
                break;
        }

        Destroy(collider.gameObject);
    }
}