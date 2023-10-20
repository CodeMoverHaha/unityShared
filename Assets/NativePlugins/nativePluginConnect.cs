using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System;
using System.Runtime.InteropServices;

public class nativePluginConnect: MonoBehaviour {

    /*
   * function:UpdataSharedD3D11Texture2D  每帧更新Texture
   * param1: UnityTexture RT Native指针
   */   
    
     [DllImport("nativePlugin")]
     public static extern void UpdataSharedD3D11Texture2D(IntPtr UnityTexture);
    void Start () {

    }
	
	void Update () {
         RenderTexture renderTexture = GetComponent<Camera>().targetTexture;
         if(renderTexture)
         {   
              UpdataSharedD3D11Texture2D(renderTexture.GetNativeTexturePtr());   
         }
         
    }

}
