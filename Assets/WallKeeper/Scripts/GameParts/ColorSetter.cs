﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using sugi.cc;

public class ColorSetter : RendererBehaviour {
    public Wall.Side side;
    public bool useOverrideColor;
    public Color color;

	// Use this for initialization
	void Start () {
        var col = ProjectionController.Instance.colorL;
        if (side == Wall.Side.Right)
            col = ProjectionController.Instance.colorR;
        if (useOverrideColor)
            col = color;

        foreach (var r in renderers)
            r.SetColor("_Color", col);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
