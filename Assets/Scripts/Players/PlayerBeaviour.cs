using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeaviour : MonoBehaviour
{
    [SerializeField] private bool isMyGround;

    private PlayerMovement playerMovement;
    private SwitchPlayers switchPlayers;

    public Groups myGroup;

    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (myGroup == Groups.Groupe2)
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
        PlayerMovement playerMovement = other.gameObject.GetComponentInChildren<PlayerMovement>();
        Groups groupe = playerMovement.myGroup;

        switchPlayers = other.gameObject.GetComponent<SwitchPlayers>();

        if (myGroup == Groups.Groupe1 && isMyGround && groupe == Groups.Groupe2)
        {
            MovmentStop();
        }

        else if (myGroup == Groups.Groupe2 && isMyGround && groupe == Groups.Groupe1)
        {
            MovmentStop();
        }
        else if (myGroup == Groups.Groupe1 && groupe == Groups.Groupe1 && switchPlayers.Icaught)
        {
            Debug.Log("You are free!!");
            MovmentAble();
        }
        else if (myGroup == Groups.Groupe2 && groupe == Groups.Groupe2 && switchPlayers.Icaught)
        {
            
            MovmentAble();
        }

    }
    private void MovmentStop()
    {
        Debug.Log("I catched you!");
        playerMovement.enabled = false;
        switchPlayers.Icaught = true;
    }
    private void MovmentAble()
    {
     Debug.Log("You are free!!");
     switchPlayers.Icaught = true;
    }
}
