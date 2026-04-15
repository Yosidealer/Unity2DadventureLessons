using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerinput : MonoBehaviour
{
    float GameStart = 0;   // variable globalisation
    Rigidbody2D rb;        // Rigidbody reference

    [SerializeField] private float jumpForce;
    [SerializeField] private float downForce;
    [SerializeField] private float rotationUp;
    [SerializeField] private float rotationDown;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float _rocketSpeed;

    void Start()
    {
        GameStart = 1; // start direct (kun je later aanpassen)
        rb = GetComponent<Rigidbody2D>(); // get rigitbody
    }

    float targetRotation;

    void Update()
    {
        float camHeight = Camera.main.orthographicSize;
        float minY = -camHeight;
        float maxY = camHeight;

        if (GameStart == 1)
        {
            // go up
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                targetRotation = 55f; // turn up
            }
            // physiscs down
            else
            {
                targetRotation = -40f; // turn down
            }

            //go down
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, -downForce);
            }


            //speedboost
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.right * _rocketSpeed * Time.deltaTime;
            }
            else
            {
                if (transform.position.x > -5.95)
                {
                    transform.position += Vector3.left * _rocketSpeed * Time.deltaTime;
                }
            }

            // rotation gebaseerd op velocity
            float tilt = Mathf.Clamp(rb.linearVelocity.y * 8f, rotationDown, rotationUp);
            float currentRotation = transform.eulerAngles.z;
            float newRotation = Mathf.LerpAngle(currentRotation, tilt, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, newRotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            SceneManager.LoadScene("dead");
            GameplayHandler.storytime = 1;
        }
    }
}