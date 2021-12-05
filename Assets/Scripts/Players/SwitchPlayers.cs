using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerNumber
{
    Player1,
    Player2,
    Player3,
    Player4
}
public class SwitchPlayers : MonoBehaviour
{
    private PlayerMovement Player1Movement;
    private PlayerMovement Player2Movement;
    private PlayerMovement Player3Movement;
    private PlayerMovement Player4Movement;

    [SerializeField] PlayerNumber PlayerNumber;

    private GameObject Player1;
    private GameObject Player2;
    private GameObject Player3;
    private GameObject Player4;

    // Start is called before the first frame update
    void Start()
    {
        Player1 = GameObject.Find("Player1");
        Player2 = GameObject.Find("Player2");
        Player3 = GameObject.Find("Player3");
        Player4 = GameObject.Find("Player4");

        Player1Movement = Player1.GetComponent<PlayerMovement>();
        Player2Movement = Player2.GetComponent<PlayerMovement>();
        Player3Movement = Player3.GetComponent<PlayerMovement>();
        Player4Movement = Player4.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            if (PlayerNumber != PlayerNumber.Player1)
            {
               
            }

        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (PlayerNumber != PlayerNumber.Player2)
            {
               
            }
        }
    }
}
