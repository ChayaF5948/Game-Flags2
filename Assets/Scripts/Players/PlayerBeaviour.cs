using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    [SerializeField] private bool isMyGround;

    private PlayerMovement PlayerMovement;

    public Groups myGroup;

    private void OnCollisionEnter(Collision collision)
    {
        if(myGroup == Groups.Groupe2)
        {
            

            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
            {
                isMyGround = true;

                this.GetComponent<BoxCollider>().isTrigger = false;
            }

            else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
            {
                isMyGround = false;

                this.GetComponent<BoxCollider>().isTrigger = true;
            }
        }

        else if (myGroup == Groups.Groupe1)
        {
            

            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
            {
                isMyGround = false;

                this.GetComponent<BoxCollider>().isTrigger = true;
            }

            else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
            {
                isMyGround = true;
                this.GetComponent<BoxCollider>().isTrigger = false;

            }
        }



    }
    private void OnTriggerEnter(Collider other)
    {  
           if (myGroup == Groups.Groupe1 && isMyGround && other.gameObject.CompareTag("Group2"))
           {
               Debug.Log("I catched you!");
               PlayerMovement = other.gameObject.GetComponent<PlayerMovement>();
               PlayerMovement.enabled = false;
           }
       
           else if (myGroup == Groups.Groupe2 && isMyGround && other.gameObject.CompareTag("Group1"))
           {
               Debug.Log("I catched you!");
               PlayerMovement = other.gameObject.GetComponent<PlayerMovement>();
               PlayerMovement.enabled = false;
           }
       

        
    }
}
