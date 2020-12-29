using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initial : MonoBehaviour
{
    public GameObject[] Shapes;

    // Start is called before the first frame update
    void Start()
    {
        NewShape();
    }

    public void NewShape()
    {
        Instantiate(Shapes[Random.Range(0, Shapes.Length)],transform.position, Quaternion.identity);
    }
        
}
