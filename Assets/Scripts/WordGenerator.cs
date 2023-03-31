using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    
    private static string[] wordList = { "sidewalk", "robin", "three", "protect", "periodic", "somber",
                                        "majestic", "jump", "pretty", "wound", "jazzy", "memory", "join",
                                        "grade", "boot", "cloudy", "sick", "mug", "hot", "tart", "dangerous",
                                        "mother", "rustic", "economic", "weird", "cut", "parallel", "wood",
                                        "encouraging", "interrupt", "guide", "long", "chief", "signal", "rely",
                                        "hair", "representative", "earth", "grate", "proud", "feel", "hilarious",
                                        "addition", "silent", "play", "floor", "numerous", "friend", "pizza",
                                        "building", "organic", "past", "mute", "unusual", "mellow", "crate",
                                        "protest", "painstaking", "soceity", "eager", "heap", "dramatic", "present",
                                        "box", "pies", "awesome", "root", "available", "sleet", "boring", "anger",
                                        "tasty", "spare", "tray", "scarce", "account", "spot", "thought", "distinct",
                                        "nimble", "ablaze", "thoughtless", "love", "verdict", "giant", "cat",
                                        "blue", "frog", "lizard", "dragon", "purse", "phone", "turtle", "brush", 
                                        "toad", "otter", "river"};

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
