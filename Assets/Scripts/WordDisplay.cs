using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;
    static int chances = 3;
    public Text LivesText;
    public static int charsTyped;
    public static int correctTyped;


    public AudioSource someSound;

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter ()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
        correctTyped++;
    }

    public void RemoveWord ()
    {
        Destroy(gameObject);
    }

    private void Update ()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);

        LivesText.text = chances.ToString();

        if (Input.anyKeyDown)
        {
            someSound.Play();
            charsTyped++;
        }
    }

    public void chancesCount()
    {
        chances--;
        if (chances == 0)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            chances = 3;
        }
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
        Debug.Log("Collision occurred");
        chancesCount();
    }

}
