using UnityEngine;

public class Flag : MonoBehaviour
{

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
            if (groupes == Groups.Groupe1)
            {
                Debug.Log("Player 1 collided with the flag ");
                gameManager.IsConquered = true;
            }

        }
    }
}
