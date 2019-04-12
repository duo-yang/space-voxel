﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBehavior : MonoBehaviour {

  public GameObject blockRoot;

  public static bool isEmpty = true;

  // public GameObject gravityButton;
  public Color emitColor = Color.black;

  private Renderer _rend;

  // Use this for initialization
  void Start () {
    _rend = GetComponent<Renderer>();
    _rend.material.SetColor("_EmissionColor", Color.black);
  }
	
	// Update is called once per frame
	void Update () {
		
	}

  public void clearBlocks () {
    for (int i = blockRoot.transform.childCount - 1; i >= 0; i--) {
      Destroy(blockRoot.transform.GetChild(i).gameObject);
    }
    if (_rend != null) _rend.material.SetColor("_EmissionColor", Color.black);
    isEmpty = true;
  }

  public void newBlock() {
    isEmpty = false;
    if (_rend != null) _rend.material.SetColor("_EmissionColor", emitColor);
  }

}
