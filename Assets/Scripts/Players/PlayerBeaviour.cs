using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    public bool isMyGround;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe1"))
        {
            isMyGround = true;
        }

        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("AreaGroupe2"))
        {
            isMyGround = false;
        }

    }
    private void OnTiggerEnter(Collider other)
    {
        if (isMyGround && other.gameObject.CompareTag("Group2"))
        {
           
        }
    }
}
