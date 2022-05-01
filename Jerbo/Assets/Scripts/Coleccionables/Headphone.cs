using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headphone : MonoBehaviour
{
    // Start is called before the first frame update

    public int HDValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(HDValue);
        }
    }
}
