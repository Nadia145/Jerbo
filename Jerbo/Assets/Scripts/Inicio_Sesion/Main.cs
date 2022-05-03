using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public static Main Instance;
    public web Web;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Web = GetComponent<web>();
    }

    
}
