using UnityEngine;
using UnityEngine.UI;

public class AutoRunButton : MonoBehaviour
{
	public void OnClick()
	{
		Debug.Log("AUTORUNが押された");



		GameObject _go = GameObject.Find("AutoRunButton");

		GameObject _ga = GameObject.Find("GameMain");
		MainScript _ms = _ga.GetComponent<MainScript>();


		if (_ms.autoRunFlg == false)
		{
			_go.GetComponent<Image>().color = new Color(200.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f);
			_ms.autoRunFlg = true;
		}
		else
		{
			_go.GetComponent<Image>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
			_ms.autoRunFlg = false;
		}




	}
}
