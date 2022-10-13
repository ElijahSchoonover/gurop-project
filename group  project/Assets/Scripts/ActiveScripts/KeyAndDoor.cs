using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAndDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public int keyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(key);
        keyCount++;
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Door")
        {
            Destroy(collision.gameObject);
            keyCount = 0;
        }

    }
}
