using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour {
	private ControladorLinguagens _ctlLinguagens;

	public Text _txtTituloSelecionar;
	public Text _txtNome;
	public Text _txtTituloProximo;
	public Text _txtTituloAnterior;

	public Text _txtTituloMenu;
	public Text[] _txtTrancados = new Text[3];
	public Text _txtAdicionarPontos;
	public Text _txtVoltarMenu;

	// Use this for initialization
	void Start () {
		this._ctlLinguagens = FindObjectOfType <ControladorLinguagens>();
		this.atualizarUI ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void atualizarUI(){
		if(this._txtNome!=null){
			this._txtNome.text = this._ctlLinguagens._nomeSelecionada;	
		}

		if(this._txtTituloSelecionar!=null){
			this._txtTituloSelecionar.text = this._ctlLinguagens._linguagemSelecionada.titulo_selecionar_linguagem;
		}

		if(this._txtTituloProximo!=null){
			this._txtTituloProximo.text = this._ctlLinguagens._linguagemSelecionada.proximo;
		}

		if(this._txtTituloAnterior!=null){
			this._txtTituloAnterior.text = this._ctlLinguagens._linguagemSelecionada.anterior;	
		}

		if(this._txtTituloMenu!=null){
			this._txtTituloMenu.text = this._ctlLinguagens._linguagemSelecionada.titulo_menu_selecionar_level;
		}

		for (int i = 0; i < this._txtTrancados.Length; i++) {
			if(this._txtTrancados[i]!=null && this._txtTrancados[i].text!=""){
				this._txtTrancados[i].text =  this._ctlLinguagens._linguagemSelecionada.trancado;
			}
		}

		if(this._txtAdicionarPontos!=null){
			this._txtAdicionarPontos.text = this._ctlLinguagens._linguagemSelecionada.adicionar_pontos;
		}

		if(this._txtVoltarMenu!=null){
			this._txtVoltarMenu.text = this._ctlLinguagens._linguagemSelecionada.voltar_menu;
		}
	}

	public void selecionarProxima(){
		this._ctlLinguagens.selecionarProxima ();
		this.atualizarUI ();
	}

	public void selecionarAnterior(){
		this._ctlLinguagens.selecionarAnterior ();
		this.atualizarUI ();
	}
}
