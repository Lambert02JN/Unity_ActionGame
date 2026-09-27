using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampEffect : MonoBehaviour
{
    [Range(0, 1)]
    public float dissolveThreshold;
    public Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.SetFloat("_Threshold", dissolveThreshold);
    }
}
