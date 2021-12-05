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
    [SerializeField] private LayerMask areaMask;
    private void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.gameObject.GetComponentInChildren<PlayerMovement>();
            Groups groupes = playerMovement.myGroup;
            if (groupes == Groups.Groupe1 && myFlag == Groups.Groupe2)
            {
                transform.parent.GetComponent<Renderer>().material = area[0];
                //transform.parent.layer = 7;
                Debug.Log("Player 1 collided with the flag ");
                //gameObject.SetActive = false;
                gameManager.IsConqueredGro1 = true;
                gameObject.SetActive(false);
                flag.SetActive(true);
            }
            else if (groupes == Groups.Groupe2 && myFlag == Groups.Groupe1)
            {
                transform.parent.GetComponent<Renderer>().material = area[1];
                Debug.Log("Player 2 collided with the flag ");
                gameManager.IsConqueredGro2 = true;

                //foreach (Transform child in transform)
                //{
                //    child.gameObject.SetActive(true);

                //}
                gameObject.SetActive(false);
                flag.SetActive(true);

            }
        }
    }
}
