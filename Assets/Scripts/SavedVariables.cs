using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SavedPieceInfo {
	public Vector3 initialLockPosition;
	public int pieceType; // 0 - cone, 1 - body, 2 - booster, 3 - fin
	public int pos;
	public Vector3 vectorPos;

	public SavedPieceInfo(Vector3 initialLockPosition, int pieceType, int pos, Vector3 vectorPos)
	{
		this.initialLockPosition = initialLockPosition;
		this.pieceType = pieceType;
		this.pos = pos;
		this.vectorPos = vectorPos;
	}
}

public class SavedVariables : MonoBehaviour {

	public List<int> distanceVals = new List<int> () {-1, -1, -1, -1, -1, -1, -1};
	public int playerState;
	public int trialNumber = 1;

	// public bool gameStarted = true; // DEMO CHANGE
	public bool gameStarted = false;

	public int saveCone;
	public int saveCone2;
	public int[] saveFin;
	public int[] saveBoost;
	public int[] saveBody;

	public List<SavedPieceInfo> previousTrialRocketPieces = new List<SavedPieceInfo> ();

	void Awake() {
		if (Application.loadedLevelName == "Level1") {
			saveCone = saveCone2 = 2;

			saveFin = new int[4];
			saveFin [0] = saveFin [1] = saveFin [2] = saveFin [3] = 2;

			saveBoost = new int[4];
			saveBoost[0] = saveBoost[1] = saveBoost[2] = saveBoost[3] = 2;

			saveBody = new int[8];
			saveBody[0] = saveBody[1] = saveBody[2] = saveBody[3] = saveBody[4] = saveBody[5] = saveBody[6] = saveBody[7] = 2;
		}
		DontDestroyOnLoad (this);
	}
}
