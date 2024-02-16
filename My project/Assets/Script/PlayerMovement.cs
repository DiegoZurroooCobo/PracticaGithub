// Holaaaaa
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private KeyCode up = KeyCode.W;
    private Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(up))
        {
            dir = new Vector2(0, 1);
        }
    }
}
