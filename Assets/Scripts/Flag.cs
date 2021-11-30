using UnityEngine;

public class Flag : MonoBehaviour
{private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.gameObject.GetComponentInChildren<PlayerMovement>();
            Groups groupes = playerMovement.myGroup;
            if (groupes == Groups.Groupe1)
            {
                Debug.Log("Player 1 collided with the flag ");
            }

        }
    }
}
