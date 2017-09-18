﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControladorMenu : MonoBehaviour {
	public GameObject _levelSlots;
	public GameObject _slots;
	public Level[] _levels;

	public ControladorJogador _ctlJogador;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < _levels.Length; i++) {
			GameObject slot = Instantiate (_levelSlots);
			slot.transform.SetParent (_slots.transform);
			slot.GetComponent<LevelSlots> ().txtLevel.text = _levels [i].level.ToString();
			if(i<_ctlJogador._jogador.levels.Count){
				if (_levels [i].pontos <= _ctlJogador._jogador.levels [i].pontos) {
					slot.GetComponent<LevelSlots> ().txtMsg.text = "";
					slot.GetComponent<LevelSlots> ().txtPontos.text = _ctlJogador._jogador.levels [i].pontos.ToString ();
				}
			}else {
				slot.GetComponent<Button> ().interactable = false;
				slot.GetComponent<LevelSlots> ().txtPontos.text = _levels [i].pontos.ToString();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
