using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    //public static int numChars = WordDisplay.charsTyped;
    //float numChars2 = (float)numChars;
    public Text CharsText;

    private int wordsMade = WordSpawner.wordsCreated;
    public Text CreatedText;

    //public static int numCorrect = WordDisplay.correctTyped;
    public Text CorrectText;
    //float numCorrect2 = (float)numCorrect;

    public Text PercentText;
    private float scorePercent;

    void Calculate ()
    {
        int numChars = WordDisplay.charsTyped;
        float numChars2 = (float)numChars;
        int numCorrect = WordDisplay.correctTyped;
        float numCorrect2 = (float)numCorrect;
        scorePercent = numCorrect2 / numChars2 * 100;
    }

    void Start()
    {
        Debug.Log("Value of charsTyped is " + WordDisplay.charsTyped);
        Debug.Log("Value of correctTyped is " + WordDisplay.correctTyped);
        Calculate();

        CharsText.text = "You typed " + WordDisplay.charsTyped.ToString() + " characters!";

        CreatedText.text = wordsMade.ToString() + " words were used!";

        CorrectText.text = "You typed " + WordDisplay.correctTyped.ToString() + " characters correctly!";

        var result = scorePercent.ToString("F2");
        PercentText.text = result + "% of characters were typed correctly!";
    }

    void Update()
    {
        /*
        Calculate();

        CharsText.text = "You typed " + numChars.ToString() + " characters!";

        CreatedText.text = wordsMade.ToString() + " words were used!";

        CorrectText.text = "You typed " + numCorrect.ToString() + " characters correctly!";

        var result = scorePercent.ToString("F2");
        PercentText.text = "You typed " + result + "% of characters correctly!";
        */
    }
}
