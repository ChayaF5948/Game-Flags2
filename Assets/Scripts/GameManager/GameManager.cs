using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction OnFlagConquered;

    private bool isConqueredGro1 = false;
    public bool IsConqueredGro1
    {
        get { return isConqueredGro1; }
        set
        {
            isConqueredGro1 = value;
            Debug.Log("The flag Caught Group1");
            if (isConqueredGro1)
            {
                OnFlagConquered?.Invoke();
                isConqueredGro1 = false;
            }
        }
    }
    private bool isConqueredGro2 = false;
    public bool IsConqueredGro2
    {
        get { return isConqueredGro2; }
        set
        {
            isConqueredGro2 = value;
            Debug.Log("The flag Caught Group2");
            if (isConqueredGro2)
            {
                OnFlagConquered?.Invoke();
                isConqueredGro2 = false;
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
