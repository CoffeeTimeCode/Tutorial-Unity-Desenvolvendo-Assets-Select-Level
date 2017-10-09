using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour {
	public Jogador _jogador;
	public ControladorArquivos _ctlArquivos;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		this._ctlArquivos = new ControladorArquivos ();
		this.carregar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void adicionarLevel(Level level){
		this._jogador.levels.Add (level);
	}

	public void salvar(){
		this._ctlArquivos.criarArquivo ("jogador.json",JsonUtility.ToJson(this._jogador),true);
	}

	private void carregar(){
		if(this._ctlArquivos.validarArquivo("jogador.json")){
			this._jogador = this._ctlArquivos.lerJson<Jogador> ("jogador.json");
		}else{
			_jogador = new Jogador ("Teste", new List<Level>());
			this.adicionarLevel (new Level(1,0));
		}
	}
}
