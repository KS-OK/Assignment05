using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Reload : MonoBehaviour
{
    
    private void Awake() 
    {
        WordDisplay.charsTyped = 0;
        WordDisplay.correctTyped = 0;
        WordSpawner.wordsCreated = 0;

        //ScoreDisplay.numChars = 1;
        //ScoreDisplay.numCorrect = 1;

        //Debug.Log("Value of charsTyped is " + WordDisplay.charsTyped);
    }
    
}
