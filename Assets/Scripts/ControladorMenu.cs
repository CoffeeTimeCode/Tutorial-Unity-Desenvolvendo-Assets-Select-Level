using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMenu : MonoBehaviour {
	public GameObject _levelSlots;
	public GameObject _slots;
	public Level[] _levels;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < _levels.Length; i++) {
			GameObject slot = Instantiate (_levelSlots);
			slot.transform.SetParent (_slots.transform);
			slot.GetComponent<LevelSlots> ().txtLevel.text = _levels [i].level.ToString();
			slot.GetComponent<LevelSlots> ().txtPontos.text = _levels [i].pontos.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
