using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelOne : MonoBehaviour {

	public Button Button1;


	public void ButtonOne () {
		SceneManager.LoadScene ("Level1", LoadSceneMode.Single);
	}
}
