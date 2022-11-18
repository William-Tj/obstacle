using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float xValue=0f;
    [SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, xValue * Time.deltaTime, 0);
    }

}
