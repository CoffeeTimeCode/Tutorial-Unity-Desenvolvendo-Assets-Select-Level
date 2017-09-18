using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour {
	public Jogador _jogador;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		_jogador = new Jogador ("Teste", new List<Level>());
		this.adicionarLevel (new Level(1,0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void adicionarLevel(Level level){
		this._jogador.levels.Add (level);
	}
}
