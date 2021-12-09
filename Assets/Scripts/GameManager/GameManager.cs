using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityAction<int, int> OnFlagConqueredGro1;
    public UnityAction<int, int> OnFlagConqueredGro2;


    private int flagGro1 = 4;
    private int flagGro2 = 4;

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
                OnFlagConqueredGro1?.Invoke(flagGro1,flagGro2);
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
                OnFlagConqueredGro2?.Invoke(flagGro2,flagGro1);
                isConqueredGro2 = false;
            }
        }
    }
    public int FlagGro1
    {
        get { return flagGro1;}
        set { flagGro1 = value; }
    }
    public int FlagGro2
    {
        get { return flagGro2; }
        set { flagGro2 = value; }
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
