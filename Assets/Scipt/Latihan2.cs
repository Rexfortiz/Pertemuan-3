using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour
{
    public int nilaiA, nilaiB;
    [Range(1, 5)]
    public int nilaiC;

    int total;
    // Start is called before the first frame update
    void Start()
    {
        total = (nilaiA + nilaiB) * nilaiC;
        Debug.Log("Total: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
