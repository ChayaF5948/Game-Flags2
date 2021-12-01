using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField]
    private Groups myFlag;

    private GameManager gameManager;

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
            if (groupes == Groups.Groupe1&&myFlag == Groups.Groupe2)
            {
                Debug.Log("Player 1 collided with the flag ");
                gameManager.IsConqueredGro1 = true;

            }
            else if (groupes == Groups.Groupe2&&myFlag == Groups.Groupe1)
            {
                Debug.Log("Player 2 collided with the flag ");
                //gameManager.IsConquered = true;
            }

        }
    }
}
