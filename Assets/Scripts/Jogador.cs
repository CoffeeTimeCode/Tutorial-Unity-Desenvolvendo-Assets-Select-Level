using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador {
	public string nome;
	public List<Level> levels;

	public Jogador(string nome, List<Level> levels){
		this.nome = nome;
		this.levels = levels;
	}
}
