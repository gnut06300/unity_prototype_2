using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public GameObject projectilePrebab;
    private float movementX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player
        }
    }*/

    void OnMove(InputValue movementValue)
    {
        movementX = movementValue.Get<float>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * movementX * Time.deltaTime * speed);
    }

    void OnLaunch()
    {
        // Launch a projectile from player
        Debug.Log("Lauch Pizza");
        Instantiate(projectilePrebab, transform.position, projectilePrebab.transform.rotation);
    }

}
