using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        
        while (true)
        {
            int number = random.Next(1, 21);

            if (number == 5)
            {
                continue;
            }

            Debug.Log("Generated number: " + number);
            
            if (number == 15)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
