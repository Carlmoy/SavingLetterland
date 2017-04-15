using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLev1 : MonoBehaviour {
	public Button ButtonStart;


	public void ButStart () {
		SceneManager.LoadScene ("Level1", LoadSceneMode.Single);
	}
}
