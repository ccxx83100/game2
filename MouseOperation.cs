using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOperation
{

	public string mouseLRUD = "STOP";
	public Vector3 sw_startPos, sw_endPos;
	public float sw_minMoveMouse = 0.1f;

	public void MouseReset()
	{
		Debug.Log("MOUSE OPERATION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		sw_startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
	public void MouseClickDrag()
	{
		//クリック
		if (Input.GetMouseButtonDown(0))
		{
			sw_startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log(sw_startPos.x + ":" + sw_startPos.y);
			Debug.Log("Click");
		}
		//リリース
		if (Input.GetMouseButtonUp(0))
		{
			sw_endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log("Release");
		}
		//ホールド
		if (Input.GetMouseButton(0))
		{
			//Debug.Log("--------hold---------");

			//現在のスクリーンワールド座標取得
			Vector3 _convert = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			float sw_nowPosX = _convert.x;
			float sw_nowPosY = _convert.y;
			Debug.Log("sw_nowPosX" + sw_nowPosX);
			Debug.Log("sw_nowPosY" + sw_nowPosY);

			//クリック位置と現在地の差分
			float moveX = sw_startPos.x - sw_nowPosX;
			float moveY = sw_startPos.y - sw_nowPosY;


			Debug.Log("moveX:" + moveX);
			Debug.Log("moveY:" + moveY);


			//絶対差分を取得
			float mathAbsX = Mathf.Abs(moveX);
			float mathAbsY = Mathf.Abs(moveY);

			if (mouseLRUD == "STOP")
			{
				//差分により移動方向を取得
				if (mathAbsX > mathAbsY && mathAbsX >= sw_minMoveMouse)
				{
					if (moveX < 0)
					{
						Debug.Log("右移動");
						mouseLRUD = "R";

					}
					else
					{
						Debug.Log("左移動");
						mouseLRUD = "L";
					}
				}
				else if (mathAbsX < mathAbsY && mathAbsY >= sw_minMoveMouse)
				{
					if (moveY < 0)
					{
						Debug.Log("上移動");
						mouseLRUD = "U";
					}
					else
					{
						Debug.Log("下移動");
						mouseLRUD = "D";
					}
				}
			}
		}





	}
}


