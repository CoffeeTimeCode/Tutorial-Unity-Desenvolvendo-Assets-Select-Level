using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level {
	public int level;
	public int pontos;

	public Level(int level, int pontos){
		this.level = level;
		this.pontos = pontos;
	}
}
