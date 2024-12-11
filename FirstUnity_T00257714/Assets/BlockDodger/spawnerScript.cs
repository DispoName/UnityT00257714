using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{

    public GameObject cubePrefab;
    // Update is called once per frame
    void Update()
    {

        int decider = UnityEngine.Random.Range(0, 100000);
        int chance = 30;

        if (decider < chance)
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    
    }
}
