using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMm : MonoBehaviour {
    public Button ButtonBackToMainMenu;
    

    public void BackToM () {
    SceneManager.LoadScene("MainMenu");
    }
}
  

