using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{
   [SerializeField] private float backgroundSpeed;
   [SerializeField] private Renderer backgroundRenderer;

   private void Update()
   {
      backgroundRenderer.material.mainTextureOffset += new Vector2(0,backgroundSpeed * Time.deltaTime);
   }
}
