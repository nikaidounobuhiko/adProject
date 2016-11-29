using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

	private GameObject text;
	private Color color;
	private bool flg = false;

	// Use this for initialization
	void Start () {
		text = GameObject.Find ("Text");
		color.r = 1.0f;
		color.g = 1.0f;
		color.b = 0.0f;
		color.a = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		text.GetComponent<CanvasRenderer> ().SetColor (color);

		if (color.a < 0.0f) {
//			color.r = Random.Range (0.0f, 1.0f);
//			color.g = Random.Range (0.0f, 1.0f);
//			color.b = Random.Range (0.0f, 1.0f);
			flg = false;
		}
		if (color.a > 1.0f) {
			flg = true;
		}

		if ( flg == false )
			color.a += 0.015f;
		if ( flg == true )
			color.a -= 0.014f;
	}
}
