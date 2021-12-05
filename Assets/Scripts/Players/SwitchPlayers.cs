using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchPlayers : MonoBehaviour
{

    private PlayerMovement Player1Movement;
    private PlayerMovement Player2Movement;
    private PlayerMovement Player3Movement;
    private PlayerMovement Player4Movement;

    PlayerNumber PlayerNumber;

    

    // Start is called before the first frame update
    void Start()
    {
        Player1Movement = GameObject.Find("Player1").GetComponent<PlayerMovement>();
        Player2Movement = GameObject.Find("Player2").GetComponent<PlayerMovement>();
        Player3Movement = GameObject.Find("Player3").GetComponent<PlayerMovement>();
        Player4Movement = GameObject.Find("Player4").GetComponent<PlayerMovement>();

        Player1Movement.enabled = true;
        Player2Movement.enabled = false;
        Player3Movement.enabled = false;
        Player4Movement.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {            
                Player1Movement.enabled = true;
                Player2Movement.enabled = false;
                Player3Movement.enabled = false;
                Player4Movement.enabled = false;

        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
            Player1Movement.enabled = false;
            Player2Movement.enabled = true;
            Player3Movement.enabled = false;
            Player4Movement.enabled = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            Player1Movement.enabled = false;
            Player2Movement.enabled = false;
            Player3Movement.enabled = true;
            Player4Movement.enabled = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            Player1Movement.enabled = false;
            Player2Movement.enabled = false;
            Player3Movement.enabled = false;
            Player4Movement.enabled = true;
        }


    }
}
