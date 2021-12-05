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
    private PlayerMovement PlayerMovement;

    [SerializeField] PlayerNumber PlayerNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
