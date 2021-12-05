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
                //transform.parent.GetComponent<Renderer>().material = area[0];
                //transform.parent.gameObject.layer = 6; 
                //Debug.Log("Player 1 collided with the flag ");
                
                gameManager.IsConqueredGro1 = true;
                gameObject.SetActive(false);
                flag.SetActive(true);
                //ChangeLayer();
                transform.parent.gameObject.layer = 6;
                transform.parent.GetComponent<Renderer>().material = area[0];

            }
            else if (groupes == Groups.Groupe2 && myFlag == Groups.Groupe1)
            {
                //transform.parent.GetComponent<Renderer>().material = area[1];
                //Debug.Log("Player 2 collided with the flag ");
                gameManager.IsConqueredGro2 = true;

                //foreach (Transform child in transform)
                //{
                //    child.gameObject.SetActive(true);

                //}
                gameObject.SetActive(false);
                flag.SetActive(true);
                //ChangeLayer();

            }
        }
    }
    //private void ChangeLayer()
    //{
    //    //LayerMask areas = transform.parent.GetComponent<LayerMask>();
        //if(areas == LayerMask.NameToLayer("AraeGroup1"))
        //{
        //    transform.parent.gameObject.layer = 7;
        //    transform.parent.GetComponent<Renderer>().material = area[1];
        //}
        //else if (areas == LayerMask.NameToLayer("AraeGroup2"))
        //{
        //    transform.parent.gameObject.layer = 6;
        //    transform.parent.GetComponent<Renderer>().material = area[1];
        //}
    //}
}
