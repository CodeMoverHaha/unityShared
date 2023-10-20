using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System;
using System.Runtime.InteropServices;
using System.IO;


public class SetRenderTexture : MonoBehaviour
{
    public RenderTexture LowResRT;

   [DllImport("nativePlugin")]
    public static extern void UpdataSharedD3D11Texture2D(IntPtr UnityTexture);
    void Start()
    {
      Screen.SetResolution(720, 1280, false);
    }
    private void OnRenderImage(RenderTexture src, RenderTexture des)
	{

        UpdataSharedD3D11Texture2D(LowResRT.GetNativeTexturePtr());   
		Graphics.Blit(src, des);
        
		Graphics.Blit(src,LowResRT);
	}

}

