using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan1 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake ni");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Saya Farel adalah Game Developer");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Waktu Update: " + Time.deltaTime);
    }
    void FixedUpdate()
    {
        Debug.Log("Waktu FixedUpdate: " + Time.deltaTime);
    }
    void LateUpdate()
    {
        Debug.Log("Waktu LateUpdate: " + Time.deltaTime);
    }
}
