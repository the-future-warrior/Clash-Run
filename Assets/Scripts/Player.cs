using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
