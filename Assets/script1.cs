using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    [SerializeField] float rotValue = 0;
    [SerializeField] float transValue = 0;
    [SerializeField] float factorV = 0.05f;
    [SerializeField] float factorH = -1.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Text goes here lmao");
        transform.Rotate(0,30,12);
    }

    // Update is called once per frame
    void Update()
    {
        rotValue = Input.GetAxis("Horizontal") * factorH;
        transValue = Input.GetAxis("Vertical") * factorV;
        transform.Rotate(0,0,rotValue);
        // need translations added
        transform.Translate(0,transValue, 0);
    }
}
