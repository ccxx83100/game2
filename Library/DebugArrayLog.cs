using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
デバッグ用 --unityでリスト出力できないので

使い方
DebugArrayLog dal = new DebugArrayLog();
dal.Array1DLog(*****配列****);
dal.Array2DLog(**二次元配列**);

*/

public class DebugListLog
{
	//-------------------------------------------------------------------
	//リスト出力出力
	//-------------------------------------------------------------------
	public void List1DLog<T>(List<T> arr)
	{
		string arrayPrint = "(--DebugListLog-(1D)--)\n";
		for (int i = 0; i < arr.Count; i++)
		{
			if (i != arr.Count - 1)
			{
				if (arr[i] != null)
				{
					arrayPrint += arr[i].ToString() + ",";
				}
				else
				{
					arrayPrint += null + ",";
				}
			}
			else
			{
				if (arr[i] != null)
				{
					arrayPrint += arr[i].ToString();
				}
				else
				{
					arrayPrint += null;
				}
			}
		}
		Debug.Log(arrayPrint);
	}
}

