Shader "Custom/Shadow"
{
    Properties
	{
		_MainTex ("MainTex", 2D) = "" {}
	}
 
	SubShader
	{
		Tags { "Queue" = "Transparent" }
 
		Pass
		{
			Blend SrcAlpha OneMinusSrcAlpha
			
			Color [_clrBase]
			
			Cull Off
			Lighting Off
			SetTexture [_MainTex] { combine texture, one - texture }
		}
	}

}
