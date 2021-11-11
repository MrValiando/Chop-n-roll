using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StemsText : MonoBehaviour
{
    public static int scoreValue = 0;
    Text stems;

    // Start is called before the first frame update
    void Start()
    {
        stems = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        stems.text = "Stems" + scoreValue;
    }
}
