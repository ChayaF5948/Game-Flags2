using UnityEngine;
using System.Collections;
public class Flag : MonoBehaviour
{
    [SerializeField]
    private Groups myFlag;
    [SerializeField]
    private GameObject flag;

    private GameManager gameManager;

    [SerializeField]
    private Material[] area;
    

    //[SerializeField] private LayerMask areaMask;
    private void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
        //areaMask = GetComponentInParent<LayerMask>();
    }


    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.gameObject.GetComponentInChildren<PlayerMovement>();
            Groups groupes = playerMovement.myGroup;
            if (groupes == Groups.Groupe1 && myFlag == Groups.Groupe2)
            {
                //Debug.Log("Player 1 collided with the flag ");    
                gameObject.SetActive(false);
                Player1Conquered();
            }
            else if (groupes == Groups.Groupe2 && myFlag == Groups.Groupe1)
            {
                //Debug.Log("Player 2 collided with the flag ");
                gameObject.SetActive(false);
                Player2Conquered();
            }
        }
       
    }
    private void Player1Conquered()
    {
        gameManager.IsConqueredGro1 = true;
        flag.SetActive(true);
        transform.parent.gameObject.layer = 6;
        transform.parent.GetComponent<Renderer>().material = area[0];
    }
    private void Player2Conquered()
    {
        gameManager.IsConqueredGro2 = true;
        flag.SetActive(true);
        transform.parent.gameObject.layer = 7;
        transform.parent.GetComponent<Renderer>().material = area[1];
    }
    
}
