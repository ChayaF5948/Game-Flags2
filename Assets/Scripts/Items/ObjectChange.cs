using UnityEngine;

public class ObjectChange : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void Start()
    {
        gameManager.OnFlagConquered += ChangeField;
    }
    private void ChangeField()
    {
        Debug.Log("The field change");
    }
}
