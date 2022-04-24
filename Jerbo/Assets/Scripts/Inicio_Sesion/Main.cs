using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public web Web;

    // Update is called once per frame
    void Update()
    {
        Instance = this;
        Web = GetComponent<web>();
    }
}
