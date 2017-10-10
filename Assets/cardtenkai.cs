using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardtenkai : MonoBehaviour {

	public GameObject Card1;
	public GameObject Card2;
	public GameObject Card3;
	public GameObject Card4;
	public GameObject Card5;
	public GameObject Card6;
	public GameObject Card7;
	public GameObject Card8;
	public GameObject Card9;
	public GameObject Card10;
	public GameObject Card11;
	public GameObject Card12;
	public GameObject Card13;

	public GUISkin clearSkin;

//	int[] reversed = {0,0};
//	GameObject[] revesedObj = {null,null};
	//	public int sentinel = 0;
//	float startTime = 0f;//-1.0f
//	float endTime = 0f;//-1.0f

//	public GameObject Timer = null;

	//	bool logchecker = true; 「自分のターン」を表示する変数
	//	public bool turnchecker = false;
//	int numberofpeople = 2;
	static public int playerchecker;
	//	public int turncount = 1; ターンを数える変数
	public bool fadechecker = false;
//	bool timechecker = true;
	public bool timeout = false;

//	bool check = true; //選択したカードのチェック用
	// Use this for initialization
	void Start () {
		int[] idTable = new int[52];
		for(int i = 0; i < 52; i++) idTable[i] = 0;
		for(int i = 0; i < 52; i++){
			int index = Random.Range(1,52);
			while(idTable[index] !=0) index = (index+1)%52;
			idTable[index] = (i / 4)+1;
		}

		// generate cards
		int count = 0;
		while(count < 52){
			GameObject cardobj =null;
			switch(idTable[count]){
			case 1:cardobj = (GameObject)Instantiate(Card1); break;
			case 2:cardobj = (GameObject)Instantiate(Card2); break;
			case 3:cardobj = (GameObject)Instantiate(Card3); break;
			case 4:cardobj = (GameObject)Instantiate(Card4); break;
			case 5:cardobj = (GameObject)Instantiate(Card5); break;
			case 6:cardobj = (GameObject)Instantiate(Card6); break;
			case 7:cardobj = (GameObject)Instantiate(Card7); break;
			case 8:cardobj = (GameObject)Instantiate(Card8); break;
			case 9:cardobj = (GameObject)Instantiate(Card9); break;
			case 10:cardobj = (GameObject)Instantiate(Card10); break;
			case 11:cardobj = (GameObject)Instantiate(Card11); break;
			case 12:cardobj = (GameObject)Instantiate(Card12); break;
			case 13:cardobj = (GameObject)Instantiate(Card13); break;
			}

			float x,y,z;
			float tempDeg;
			Vector3 center = GameObject.Find("Center").transform.position;
			float degree = count * Mathf.PI * 2 / 13;//プレイヤーを中心とした、地面とカードがなす角？


			if (0 <= count && count <= 12) { //1段目
				y = 3.8f; // 高さ
				tempDeg = 0; //位置のずれを調整
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (194.036f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 5f;
				z = Mathf.Sin (degree + tempDeg) * 5f;
			} else if (13 <= count && count <= 25) {//２段目
				y = 2.2f;
				tempDeg = Mathf.PI * 2 / 26; //Mathf = 円周率
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (184.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 6f;
				z = Mathf.Sin (degree + tempDeg) * 6f;
			} else if (26 <= count && count <= 38){//３段目
				y = 0.6f;
				tempDeg = 0;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (176.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 6f;
				z = Mathf.Sin (degree + tempDeg) * 6f;
			} else { // ad 4段目
				y = -1.0f;
				tempDeg = Mathf.PI * 2 / 26;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (166.034f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 5f;
				z = Mathf.Sin (degree + tempDeg) * 5f;
			}

			cardobj.transform.position = new Vector3 (x + center.x, y, z + center.z);// カードの位置座標 center = 中心
			// cardobj.transform.position = new Vector3((float)(count%6)*2.0f,0.0f,(float)(count/6)*2.0f); //カードの位置　(x横:,y:地面,z:縦)
			cardobj.GetComponent<reverseCard>().id = idTable[count];

			count++;// 出したカードの枚数をカウント


		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
