using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ステージファイル
public class StageList
{
	public int stageNo;
	public int[] startPos;
	public int[,] stageArray;
	public int[,] hintArray;
	public int breakCount;
	public float stageScale;

	//-------------------------------------------------------------------------------------------------------------------------
	//ステージ数を増やしたら増やす
	//-------------------------------------------------------------------------------------------------------------------------
	public int switchStage = 8;
	public (int[], int[,], int[,], float, int) StageSetUP()
	{

		switch (stageNo)
		{
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 1 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 1:
				stageScale = 0.09f;
				startPos = new int[] { 1, 3 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,0,0},
						{0,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,0},
						{0,0,0,0,0,0,0,0}


				};
				hintArray = new int[,] { { 3, 5 } };
				breakCount = 2;

				break;
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 2 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 2:
				stageScale = 0.12f;
				startPos = new int[] { 3, 2 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0},
						{0,1,1,1,0,0},
						{0,1,1,1,0,0},
						{0,1,1,1,1,0},
						{0,1,1,0,1,0},
						{0,1,1,1,1,0},
						{0,0,0,0,0,0}

				};
				hintArray = new int[,] { { 5, 1 } };
				breakCount = 2;

				break;
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 3 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 3:
				stageScale = 0.09f;
				startPos = new int[] { 2, 2 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,0,0},
						{0,1,1,1,1,1,0,0},
						{0,1,1,1,1,1,0,0},
						{0,0,1,0,0,1,1,0},
						{0,0,1,1,1,1,0,0},
						{0,0,0,0,0,0,0,0},
				};
				hintArray = new int[,] { { 2, 4 } };
				breakCount = 2;
				break;
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 4 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 4:
				stageScale = 0.065f;
				startPos = new int[] { 2, 2 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,0,0,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,0,0,0,0,1,1,0},
						{0,1,1,0,0,0,0,1,1,0},
						{0,1,1,0,0,0,0,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,0,0,0,0,0,0,0,0,0},


				};
				hintArray = new int[,] { { 3, 3 }, { 3, 4 } };
				breakCount = 2;
				break;
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 5 
			//-------------------------------------------------------------------------------------------------------------------------
			case 5:
				stageScale = 0.06f;
				startPos = new int[] { 1, 1 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,0,1,1,0},
						{0,1,1,1,1,1,0,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,0,0,1,1,1,0},
						{0,1,1,1,0,0,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,0,1,0,1,1,1,0},
						{0,1,1,0,1,1,1,1,1,0},
						{0,0,0,0,0,0,0,0,0,0},


				};
				hintArray = new int[,] { { 1, 4 }, { 6, 5 } };
				breakCount = 3;
				break;

			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 6 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 6:
				stageScale = 0.068f;
				startPos = new int[] { 2, 2 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,1,1,0,0},
						{0,1,1,1,1,1,0,1,1,0},
						{0,1,1,1,0,1,0,1,1,0},
						{0,0,1,1,0,1,1,1,1,0},
						{0,0,1,1,0,1,0,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,0,0,0,0},
						{0,0,0,0,0,0,0,0,0,0},
				};
				hintArray = new int[,] { { 6, 1 }, { 4, 2 }, { 3, 7 } };
				breakCount = 3;
				break;
			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 7 OK
			//-------------------------------------------------------------------------------------------------------------------------
			case 7:
				stageScale = 0.068f;
				startPos = new int[] { 2, 4 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0,0,0},
						{0,0,0,1,1,1,1,1,1,0},
						{0,0,0,1,1,1,1,1,1,0},
						{0,0,1,1,0,1,1,1,1,0},
						{0,0,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,0,0,1,1,1,1,1,1,0},
						{0,0,0,1,1,1,1,1,1,0},
						{0,0,0,0,0,0,0,0,0,0},

				};
				hintArray = new int[,] { { 5, 3 }, { 4, 5 } };
				breakCount = 2;
				break;

			//-------------------------------------------------------------------------------------------------------------------------
			//Stage: 8 
			//-------------------------------------------------------------------------------------------------------------------------
			case 8:
				stageScale = 0.068f;
				startPos = new int[] { 2, 2 };
				stageArray = new int[,]
				{
						{0,0,0,0,0,0,0,0,0,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,1,1,1,1,1,1,1,1,0},
						{0,0,0,0,0,0,0,0,0,0},

				};
				hintArray = new int[,] { { 5, 3 }, { 4, 5 } };
				breakCount = 99;
				break;
			default:
				stageScale = 0.25f;
				startPos = new int[] { 0, 0 };
				stageArray = new int[,]
				{
						{1,1},
						{1,1}
				};
				hintArray = new int[,] { { 0, 0 } };
				breakCount = 2;
				break;
		}

		return (startPos, stageArray, hintArray, stageScale, breakCount);
	}
}
