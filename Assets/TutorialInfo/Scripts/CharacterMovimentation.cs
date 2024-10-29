using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CharacterMovimentation : MonoBehaviour { 

    public float moveSpeed;
    //public Rigidbody rigidB;
    public float jumpForce;
    public CharacterController controller;
    private Vector3 moveDirection;
    public float 

    // Start is called before the first frame update
    void Start()
    {
        //rigidB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed
             , moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))


        {
            moveDirection = jumpForce;
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);

    }
        /*

                if (Input.GetButtonDown("Jump"))
                {
                    rigidB.velocity = new Vector3(rigidB.velocity.x,
                        jumpForce, rigidB.velocity.z);
                }
            }
               */
    }
