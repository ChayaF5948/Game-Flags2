using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchPlayers : MonoBehaviour
{
    [SerializeField]
    private PlayerNumber playerNumber;
    private PlayerMovement playerMovement;


    [SerializeField]
    private bool iCaught = false;
    public bool Icaught
    {

        get { return iCaught; }
        set { iCaught = value; }
    }



    // Start is called before the first frame update
    void Start()
    {

        playerMovement = GetComponent<PlayerMovement>();
        if (playerNumber == PlayerNumber.Player1)
        {
            playerMovement.enabled = true;
        }
        if (playerNumber == PlayerNumber.Player2)
        {
            playerMovement.enabled = false;
        }
        if (playerNumber == PlayerNumber.Player3)
        {
            playerMovement.enabled = false;
        }
        if (playerNumber == PlayerNumber.Player4)
        {
            playerMovement.enabled = false;
        }


       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) && !iCaught)
        {
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = true;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player4)
            {
                playerMovement.enabled = false;
            }



        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) && !iCaught)
        {
            //witchPlayer[1] = curnetPlayer;
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = true;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player4)
            {
                playerMovement.enabled = false;
            }

        }

        else if (Input.GetKeyDown(KeyCode.Alpha3) && !iCaught)
        {
            //witchPlayer[2] = curnetPlayer;
            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = true;
            }
            if (playerNumber == PlayerNumber.Player4)
            {
                playerMovement.enabled = false;
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4) && !iCaught)
        {

            if (playerNumber == PlayerNumber.Player1)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player2)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player3)
            {
                playerMovement.enabled = false;
            }
            if (playerNumber == PlayerNumber.Player4)
            {
                playerMovement.enabled = true;
            }
        }
    }

        




    //private PlayerMovement Player1Movement;
    //private PlayerMovement Player2Movement;
    //private PlayerMovement Player3Movement;
    //private PlayerMovement Player4Movement;

    //PlayerNumber PlayerNumber;



    //// Start is called before the first frame update
    //void Start()
    //{
    //    Player1Movement = GameObject.Find("Player_1").GetComponent<PlayerMovement>();
    //    Player2Movement = GameObject.Find("Player_2").GetComponent<PlayerMovement>();
    //    Player3Movement = GameObject.Find("Player_3").GetComponent<PlayerMovement>();
    //    Player4Movement = GameObject.Find("Player_4").GetComponent<PlayerMovement>();

    //    Player1Movement.enabled = true;
    //    Player2Movement.enabled = false;
    //    Player3Movement.enabled = false;
    //    Player4Movement.enabled = false;
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {            
    //            Player1Movement.enabled = true;
    //            Player2Movement.enabled = false;
    //            Player3Movement.enabled = false;
    //            Player4Movement.enabled = false;

    //    }

    //    else if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {

    //        Player1Movement.enabled = false;
    //        Player2Movement.enabled = true;
    //        Player3Movement.enabled = false;
    //        Player4Movement.enabled = false;
    //    }

    //    else if (Input.GetKeyDown(KeyCode.Alpha3))
    //    {

    //        Player1Movement.enabled = false;
    //        Player2Movement.enabled = false;
    //        Player3Movement.enabled = true;
    //        Player4Movement.enabled = false;
    //    }

    //    else if (Input.GetKeyDown(KeyCode.Alpha4))
    //    {

    //        Player1Movement.enabled = false;
    //        Player2Movement.enabled = false;
    //        Player3Movement.enabled = false;
    //        Player4Movement.enabled = true;
    //    }


    //}
}
