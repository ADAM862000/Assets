using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        System.Random random = new System.Random();
        string sentence = "";
        int wordCount = 0;

        while (wordCount < 7)
        {
            int index = random.Next(words.Length);
            sentence += words[index] + " ";
            wordCount++;
        }

        Debug.Log("Funny sentence: " + sentence.Trim());
    }

}