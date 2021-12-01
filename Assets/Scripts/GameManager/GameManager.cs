using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction OnFlagConquered;

    private bool isConquered = false;
    public bool IsConquered
    {
        get { return isConquered; }
        set
        {
            isConquered = value;
            Debug.Log("The flag catch");
            if (isConquered)
            {
                OnFlagConquered?.Invoke();
                isConquered = false;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
