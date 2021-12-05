using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    [SerializeField] private bool isMyGround;

    private PlayerMovement PlayerMovement;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
        {
            isMyGround = true;
        }

        else if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
        {
            isMyGround = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (isMyGround && other.gameObject.CompareTag("Group2"))
        {
            Debug.Log("Hi! I'm an enemy!");
            other.gameObject.GetComponent<PlayerMovement>();
            PlayerMovement.enabled = false;
        }
    }
}
