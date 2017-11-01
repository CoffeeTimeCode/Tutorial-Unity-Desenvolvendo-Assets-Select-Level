using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLinguagens : MonoBehaviour {
	public string[] _linguagens;
	public Linguagem _linguagemSelecionada;
	public string _nomeSelecionada;

	private ControladorArquivos _ctlArquivos;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		this._ctlArquivos = new ControladorArquivos ();
		this.lerLinguagem ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void lerLinguagem(){
		if(this._ctlArquivos.validarDiretorio("linguagens")){
			this._linguagens = this._ctlArquivos.listarArquivos ("linguagens","*.json");
			this.selecionarLinguagem (PlayerPrefs.GetString("Selecionada"));
		}else{
			this._ctlArquivos.criarDiretorio ("linguagens");
			Linguagem padrao = new Linguagem ();
			padrao.nome_linguagem = "Português";
			padrao.titulo_selecionar_linguagem = "Trocar linguagem: ";
			padrao.proximo = "Próximo";
			padrao.anterior = "Anterior";
			padrao.titulo_menu_selecionar_level = "Selecionar Level";
			padrao.trancado = "Trancado";
			padrao.adicionar_pontos = "Adicionar Pontos";
			padrao.voltar_menu = "Voltar Menu";

			this._linguagemSelecionada = padrao;
			this._nomeSelecionada = "pt-br";
			this._ctlArquivos.criarArquivo ("linguagens/pt-br.json",JsonUtility.ToJson(padrao));
			this._linguagens = this._ctlArquivos.listarArquivos ("linguagens","*.json");

			PlayerPrefs.SetString ("Selecionada", this._nomeSelecionada);
		}
	}

	public void selecionarLinguagem(string nome){
		_linguagemSelecionada = this._ctlArquivos.lerJson<Linguagem> ("linguagens/"+nome+".json");
		this._nomeSelecionada = nome;
		PlayerPrefs.SetString ("Selecionada", nome);
	}

	public void selecionarProxima(){
		for (int i = 0; i < this._linguagens.Length; i++) {
			if(this._linguagens[i].Replace(".json","").Equals(this._nomeSelecionada)){
				if(this._linguagens.Length==(i+1)){
					this.selecionarLinguagem (this._linguagens[0].Replace(".json",""));
					this._nomeSelecionada = this._linguagens [0].Replace (".json", "");
				}else{
					this.selecionarLinguagem (this._linguagens[i+1].Replace(".json",""));
					this._nomeSelecionada = this._linguagens [i+1].Replace (".json", "");
				}
				break;
			}
		}
	}

	public void selecionarAnterior(){
		for (int i = 0; i < this._linguagens.Length; i++) {
			if(this._linguagens[i].Replace(".json","").Equals(this._nomeSelecionada)){
				if(i==0){
					this.selecionarLinguagem (this._linguagens[this._linguagens.Length-1].Replace(".json",""));
					this._nomeSelecionada = this._linguagens [this._linguagens.Length-1].Replace (".json", "");
				}else{
					this.selecionarLinguagem (this._linguagens[i-1].Replace(".json",""));
					this._nomeSelecionada = this._linguagens [i-1].Replace (".json", "");
				}
				break;
			}
		}
	}
}
