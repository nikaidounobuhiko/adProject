using UnityEngine.SceneManagement;
using NendUnityPlugin.AD;
using UnityEngine;
using System.Collections;

public class ChangeScenes : MonoBehaviour {

	public void GoToOtherScene ()
	{
		if (SceneManager.GetActiveScene ().name == "ad") {
			// NendAdBannerをアタッチしたGameObjectにアタッチされた別スクリプトでの実装と仮定します
			var banner = gameObject.GetComponent <NendAdBanner> ();
			banner.Pause ();
			banner.Hide ();

			SceneManager.LoadScene ("return");
		} else {
			SceneManager.LoadScene ("ad");
		}

	}
}


