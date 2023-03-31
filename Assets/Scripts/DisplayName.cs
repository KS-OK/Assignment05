using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    string ShowName = NameTransfer.theName;
    public GameObject NameText;
    //public Text writeScore;
    //private int newScore = Score.CurrentScore;

    public void Start()
    {
        NameText.GetComponent<Text>().text = ShowName.ToUpper();

    }
}
