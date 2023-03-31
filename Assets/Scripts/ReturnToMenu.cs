using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{


    public void ReturnToIntro()
    {
        //ResetValues.ResetStuff();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
