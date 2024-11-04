using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovimentation : MonoBehaviour
{ 
    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 1.0f;
    public CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);


        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }


        moveDirection.y += Physics.gravity.y * gravityScale * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
