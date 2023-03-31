using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class newGenerator : MonoBehaviour
{
    [SerializeField] Text all_words;

    private static string[] wordsArray = new string[1000];
    string myFilePath, fileName;

    int i;

    void Start()
    {
        fileName = "oneThousand.txt";
        myFilePath = Application.dataPath + "/" + fileName;
        ReadFromTheFile();
    }

    void DisplayAllScores()
    {
        foreach (string line in wordsArray)
        {
            all_words.text += line + "\n";
        }

    }

    public void ReadFromTheFile()
    {
        wordsArray = File.ReadAllLines(myFilePath);
        DisplayAllScores();
    }


    public static string NewGetRandomWord()
    {
        int randomIndex = Random.Range(0, wordsArray.Length);
        string newrandomWord = wordsArray[randomIndex];

        return newrandomWord;
    }
   
}
