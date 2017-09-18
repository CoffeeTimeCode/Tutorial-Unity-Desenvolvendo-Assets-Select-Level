using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelSlots : MonoBehaviour {
	public Text txtLevel;
	public Text txtMsg;
	public Text txtPontos;

	public void irParaOLevel(){
		SceneManager.LoadScene ("Level-"+txtLevel.text);
	}
}
