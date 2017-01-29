using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnNonMobile : MonoBehaviour {
	#if !UNITY_ANDROID && !UNITY_IPHONE && !UNITY_BLACKBERRY && !UNITY_WINRT || UNITY_EDITOR
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject);
	}
	
	#endif
}
