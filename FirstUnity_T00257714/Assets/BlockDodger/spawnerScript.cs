using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{

    public GameObject cubePrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    }
}
