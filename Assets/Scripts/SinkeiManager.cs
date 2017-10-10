using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SinkeiManager : MonoBehaviour {
	// Cards
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

	int[] reversed = {0,0};
	GameObject[] revesedObj = {null,null};
//	public int sentinel = 0;
	float startTime = 0f;//-1.0f
	float endTime = 0f;//-1.0f

	public GameObject Timer = null;

//	bool logchecker = true; 「自分のターン」を表示する変数
//	public bool turnchecker = false;
	int numberofpeople = 2;
	static public int playerchecker;
//	public int turncount = 1; ターンを数える変数
	public bool fadechecker = false;
	bool timechecker = true;
	public bool timeout = false;

	bool check = true; //選択したカードのチェック用


	//int score = 0;
	// Use this for initialization
	void Start () {
	 	//generate id table/
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
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (104.036f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 5f;
			    z = Mathf.Sin (degree + tempDeg) * 5f;
			} else if (13 <= count && count <= 25) {//２段目
				y = 2.2f;
				tempDeg = Mathf.PI * 2 / 26; //Mathf = 円周率
			    cardobj.transform.rotation = Quaternion.Euler (new Vector3 (94.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
			    x = Mathf.Cos (degree + tempDeg) * 6f;
				  z = Mathf.Sin (degree + tempDeg) * 6f;
			} else if (26 <= count && count <= 38){//３段目
				y = 0.6f;
				tempDeg = 0;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (86.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 6f;
				z = Mathf.Sin (degree + tempDeg) * 6f;
			} else { // ad 4段目
				y = -1.0f;
				tempDeg = Mathf.PI * 2 / 26;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (76.034f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 5f;
				z = Mathf.Sin (degree + tempDeg) * 5f;
			}

			cardobj.transform.position = new Vector3 (x + center.x, y, z + center.z);// カードの位置座標 center = 中心
			// cardobj.transform.position = new Vector3((float)(count%6)*2.0f,0.0f,(float)(count/6)*2.0f); //カードの位置　(x横:,y:地面,z:縦)
			cardobj.GetComponent<reverseCard>().id = idTable[count];

			count++;// 出したカードの枚数をカウント


		}
				playerchecker = numberofpeople; //人数確認後に代入
				Debug.Log("Player1's turn! " /*+ turncount + "T"*/);

	}

	// Update is called once per frame
	void Update () {

//        SteamVR_TrackedObject trackObject = GameObject.Find("Controller (right)").GetComponent<SteamVR_TrackedObject>();
 //       var device = SteamVR_Controller.Input((int)trackObject.index);



        if (Input.GetKeyDown(KeyCode.C) || timeout==true){
			//GameObject.Find("Panel").GetComponent<FadeInOut>().Fade();
			Timer.GetComponent<TimeCounter>().timerstart = false;
			GameObject[] objs = GameObject.FindGameObjectsWithTag("Card");
			foreach(GameObject obj in objs){
				Destroy(obj);
			}
			CheckClear();
		}

		if (/*device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)*/Input.GetMouseButton(0) && timechecker) {
//				if (startTime < 0.0f) startTime = Time.time;
						Timer.GetComponent<TimeCounter>().timerstart = true;
						timechecker = false;
		}
		if (startTime >= 300.0f) {
				Input.GetKeyDown (KeyCode.C);
		}
			// Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// RaycastHit hit;
			// if(Physics.Raycast(ray,out hit)){
			// 	if(hit.collider.gameObject.tag == "Card")
			// 		hit.collider.gameObject.GetComponent<reverseCard>().Reverse(); //裏返すモーション
			// }
		//}
	}

	void OnGUI(){
		if(CheckClear()){
			if(endTime < 0.0f) endTime = Time.time;
			GUI.skin = clearSkin;
//			GameObject.Find("Panel").GetComponent<FadeIn>().Fade();


			//GUI.Label(
				//new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),
				//string.Format("clear time:{0} sec", endTime- startTime)
						//);

//			PlayerScore ps = GameObject.Find("Player_score").GetComponent<PlayerScore>();
//							if (fadechecker) {
//									if (ps.Result () == 1) {
//											SceneManager.LoadScene ("result1");
//									} else if (ps.Result () == 2) {
//											SceneManager.LoadScene ("result2");
//									} else if (ps.Result () == 3) {
//											SceneManager.LoadScene ("draw");
//									}
//							}
			SceneManager.LoadScene("Fin 1");
		}
	}

//	public void PlayerCheck(){
//				if (logchecker == true) {
////						if (turnchecker == true) {
//						turncount = GameObject.Find ("Turn").GetComponent<TurnCounter> ().count;
////								turnchecker = false;
////						}
//						Debug.Log ("turncount=" + (turncount + 1));
//						if ((turncount + 1) % numberofpeople == 1) {
//								Debug.Log ("Player1's turn! " + (turncount + 1) + "T");
//								playerchecker = 0;
//
//						} else if((turncount + 1) % numberofpeople == 0) {
//								Debug.Log ("Player2's turn! " + (turncount + 1) + "T");
//								playerchecker = 1;
//						}
//						GameObject.Find ("Player_score").GetComponent<PlayerScore> ().player = playerchecker;
//						logchecker = false;
//				}
//
//	}

	public void ReversePost(int id,GameObject obj){

		//Debug.Log ("obj=" + obj);
//		Debug.Log ("sentinel=" + sentinel);
				if (/*reversed [0] == 0*/check) {
						reversed [0] = id;
						revesedObj [0] = obj;
						check = false;
				} else {
						reversed [1] = id;
						revesedObj [1] = obj;
						check = true;
						Check ();
				}

//				if (sentinel == 1) {
//						Check ();
//						Debug.Log ("go to check!");
//						sentinel = 0;
//				} else {
//						sentinel = 1;
//				}

		//sentinel = (sentinel + 1 )% 2;
	}

	private void Check(){
		if(reversed[0] == reversed[1]){
			Destroy(revesedObj[0]);
			Destroy(revesedObj[1]);

			GameObject.Find ("Player_score").GetComponent<PlayerScore> ().score = reversed [0];


		} else{
			revesedObj[0].GetComponent<reverseCard>().ReSet(); //ソースreverseCardのReSetにて裏返しのモーションを行う
			revesedObj[1].GetComponent<reverseCard>().ReSet();
		}
		reversed [0] = 0;
//		GameObject.Find ("Turn").GetComponent<TurnCounter> ().check = true;
//		logchecker = true;
//		PlayerCheck ();

	}

	 private bool CheckClear(){
		bool ret = false;
		GameObject[] objs = GameObject.FindGameObjectsWithTag("Card");
		if(objs.Length == 0){
			// clear process
			Timer.GetComponent<TimeCounter>().timerend = true;
			endTime = Time.time;
			ret = true;
		}
		return ret;
	}
}
