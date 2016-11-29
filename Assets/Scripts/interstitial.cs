using UnityEngine;
using System.Collections;
using NendUnityPlugin.AD;

public class interstitial : MonoBehaviour {

	// Use this for initialization
	void Start () {

		#if UNITY_IPHONE
		NendAdInterstitial.Instance.Load("308c2499c75c4a192f03c02b2fcebd16dcb45cc9", "213208");
		#elif UNITY_ANDROID
		NendAdInterstitial.Instance.Load("8c278673ac6f676dae60a1f56d16dad122e23516", "213206");
		#else
		#endif

		// 通常表示
		NendAdInterstitial.Instance.Show();

		// 広告枠を指定して表示
		//NendAdInterstitial.Instance.Show("662913");	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
