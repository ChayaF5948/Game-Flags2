using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction OnFlagConquered;

    private bool isConqueredGro1 = false;
    public bool IsConquered
    {
        get { return isConqueredGro1; }
        set
        {
            isConqueredGro1 = value;
            Debug.Log("The flag catch");
            if (isConqueredGro1)
            {
                OnFlagConquered?.Invoke();
                isConqueredGro1 = false;
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
