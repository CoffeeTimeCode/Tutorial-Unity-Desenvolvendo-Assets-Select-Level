using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorLevel : MonoBehaviour {

	public int _pontos;
	public Level _nextLevel;
	public ControladorJogador _ctlJogador;

	// Use this for initialization
	void Start () {
		_ctlJogador = GameObject.FindObjectOfType<ControladorJogador> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void adicionarPontos(int pontos){
		_pontos += pontos;
		for (int i = 0; i < _ctlJogador._jogador.levels.Count; i++) {
			if(_ctlJogador._jogador.levels[i].level==(_nextLevel.level-1)){
				_ctlJogador._jogador.levels [i].pontos += pontos;
				if(_ctlJogador._jogador.levels[i].pontos>=_nextLevel.pontos&&_ctlJogador._jogador.levels.Count==(_nextLevel.level-1)){
					_ctlJogador._jogador.levels.Add (new Level(_nextLevel.level,0));
				}
			}
		}
	}

	public void votlarMenu(){
		Destroy (_ctlJogador.gameObject);
		Destroy (GameObject.Find("ControladorLinguagens"));
		this._ctlJogador.salvar ();
		SceneManager.LoadScene ("Menu");
	}
}
