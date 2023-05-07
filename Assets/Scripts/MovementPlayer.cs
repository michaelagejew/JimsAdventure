using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
  Rigidbody rigid;
  [SerializeField] float speed = 2f;
  [SerializeField] float jumpf = 6f;
  [SerializeField] Transform grounded;
  [SerializeField] LayerMask ground;
  [SerializeField] AudioSource jumpS;
  [SerializeField] AudioSource background;
    // Start is called before the first frame update
    void Start()
    {
       rigid = GetComponent<Rigidbody>();
       background.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
      float horizon = Input.GetAxis("Horizontal");
      float vert = Input.GetAxis("Vertical");
      rigid.velocity = new Vector3(horizon*speed, rigid.velocity.y, vert*speed);
        if (Input.GetButtonDown("Jump") && IsGround())
        {
            rigid.velocity = new Vector3(rigid.velocity.x,jumpf,rigid.velocity.z);
            jumpS.Play();
        }
    }
     bool IsGround()
    {
    return Physics.CheckSphere(grounded.position, .2f, ground );
    }
}