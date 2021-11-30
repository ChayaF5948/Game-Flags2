using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Groups
{
    Groupe1,
    Groupe2
}
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
  
    [SerializeField] private float moveSpeed = 0.15f;
    [SerializeField] private float rotateSpeed = 100f;

    private const string VERTICAL1_AXIS = "Vertical1";
    private const string HORIZONTAL1_AXIS = "Horizontal1";

    private const string VERTICAL2_AXIS = "Vertical2";
    private const string HORIZONTAL2_AXIS = "Horizontal2";

    private float v1Input;
    private float h1Input;

    private float v2Input;
    private float h2Input;

    private Rigidbody rb;

    public Groups myGroup;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if(myGroup == Groups.Groupe1)
        {
                v1Input = Input.GetAxis(VERTICAL1_AXIS) * moveSpeed;
                h1Input = Input.GetAxis(HORIZONTAL1_AXIS) * rotateSpeed;
                
                //transform.Translate(Vector3.forward * v1Input * Time.deltaTime);
                //transform.Rotate(Vector3.up * h1Input * Time.deltaTime);
            
        
        }
        else if(myGroup == Groups.Groupe2)
        {
             v2Input = Input.GetAxis(VERTICAL2_AXIS) * moveSpeed;
             h2Input = Input.GetAxis(HORIZONTAL2_AXIS) * rotateSpeed;

            //transform.Translate(Vector3.forward * v2Input * Time.deltaTime);
            //transform.Rotate(Vector3.up * h2Input * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {

        if (myGroup == Groups.Groupe1)
        {
            Vector3 rotation1 = Vector3.up * h1Input;
            Quaternion angelRot1 = Quaternion.Euler(rotation1 * Time.fixedDeltaTime);
            rb.MovePosition(transform.position + transform.forward * v1Input);
            rb.MoveRotation(rb.rotation * angelRot1);
        }
        else if (myGroup == Groups.Groupe2)
        {
            Vector3 rotation2 = Vector3.up * h2Input;
            Quaternion angelRot2 = Quaternion.Euler(rotation2 * Time.fixedDeltaTime);
            rb.MovePosition(transform.position + transform.forward * v2Input);
            rb.MoveRotation(rb.rotation * angelRot2);
        }
        
    }    
}
