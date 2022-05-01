using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Rigidbody2D rb;

    private void Start()
    {
        
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY= Input.GetAxisRaw("Vertical");
        Vector3 velocity = Vector2.right * inputX + Vector2.up * inputY;
        //float velocity = inputX * moveSpeed;

        rb.MovePosition(transform.position + velocity *moveSpeed* Time.deltaTime);
        //transform.Translate(Vector3.right * velocity * Time.deltaTime);
    }

    
   
}
