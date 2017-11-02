using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SinkeiManager : MonoBehaviour {
	// Cards
//	public GameObject Card1;
//	public GameObject Card2;
//	public GameObject Card3;
//	public GameObject Card4;
//	public GameObject Card5;
//	public GameObject Card6;
//	public GameObject Card7;
//	public GameObject Card8;
//	public GameObject Card9;
//	public GameObject Card10;
//	public GameObject Card11;
//	public GameObject Card12;
//	public GameObject Card13;
	public GameObject Card1S;
	public GameObject Card1H;
	public GameObject Card1C;
	public GameObject Card1D;

	public GameObject Card2S;
	public GameObject Card2H;
	public GameObject Card2C;
	public GameObject Card2D;

	public GameObject Card3S;
	public GameObject Card3H;
	public GameObject Card3C;
	public GameObject Card3D;

	public GameObject Card4S;
	public GameObject Card4H;
	public GameObject Card4C;
	public GameObject Card4D;

	public GameObject Card5S;
	public GameObject Card5H;
	public GameObject Card5C;
	public GameObject Card5D;

	public GameObject Card6S;
	public GameObject Card6H;
	public GameObject Card6C;
	public GameObject Card6D;

	public GameObject Card7S;
	public GameObject Card7H;
	public GameObject Card7C;
	public GameObject Card7D;

	public GameObject Card8S;
	public GameObject Card8H;
	public GameObject Card8C;
	public GameObject Card8D;

	public GameObject Card9S;
	public GameObject Card9H;
	public GameObject Card9C;
	public GameObject Card9D;

	public GameObject Card10S;
	public GameObject Card10H;
	public GameObject Card10C;
	public GameObject Card10D;

	public GameObject Card11S;
	public GameObject Card11H;
	public GameObject Card11C;
	public GameObject Card11D;

	public GameObject Card12S;
	public GameObject Card12H;
	public GameObject Card12C;
	public GameObject Card12D;

	public GameObject Card13S;
	public GameObject Card13H;
	public GameObject Card13C;
	public GameObject Card13D;

	public GUISkin clearSkin;
    /*
    public GameObject HK;
    public GameObject DK;
    public GameObject SK;
    public GameObject CK;
    public GameObject HQ;
    public GameObject DQ;
    public GameObject SQ;
    public GameObject CQ;
    public GameObject HJ;
    public GameObject DJ;
    public GameObject SJ;
    public GameObject CJ;
    public GameObject HA;
    public GameObject DA;
    public GameObject SA;
    public GameObject CA;
    */
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

	int skill_A = 0;
	int skill_J = 0;
	int skill_Q = 0;
	int skill_K = 0;


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
		int count1=0,count2=0,count3=0,count4=0,count5=0,count6=0,count7=0,count8=0,count9=0,count10=0,count11=0,count12=0,count13=0;

		while(count < 52){
			GameObject cardobj =null;
			switch(idTable[count]){
//				case 1:cardobj = (GameObject)Instantiate(Card1); break;
//				case 2:cardobj = (GameObject)Instantiate(Card2); break;
//				case 3:cardobj = (GameObject)Instantiate(Card3); break;
//				case 4:cardobj = (GameObject)Instantiate(Card4); break;
//				case 5:cardobj = (GameObject)Instantiate(Card5); break;
//				case 6:cardobj = (GameObject)Instantiate(Card6); break;
//				case 7:cardobj = (GameObject)Instantiate(Card7); break;
//				case 8:cardobj = (GameObject)Instantiate(Card8); break;
//				case 9:cardobj = (GameObject)Instantiate(Card9); break;
//				case 10:cardobj = (GameObject)Instantiate(Card10); break;
//				case 11:cardobj = (GameObject)Instantiate(Card11); break;
//				case 12:cardobj = (GameObject)Instantiate(Card12); break;
//				case 13:cardobj = (GameObject)Instantiate(Card13); break;
			case 1:{
					if(count1==0) cardobj = (GameObject)Instantiate(Card1S);
					else if(count1==1) cardobj = (GameObject)Instantiate(Card1H);
					else if(count1==2) cardobj = (GameObject)Instantiate(Card1C);
					else if(count1==3) cardobj = (GameObject)Instantiate(Card1D);
					count1++;
					break;}
			case 2:{
					if(count2==0) cardobj = (GameObject)Instantiate(Card2S);
					else if(count2==1) cardobj = (GameObject)Instantiate(Card2H);
					else if(count2==2) cardobj = (GameObject)Instantiate(Card2C);
					else if(count2==3) cardobj = (GameObject)Instantiate(Card2D);
					count2++;
					break;}
			case 3:{
					if(count3==0) cardobj = (GameObject)Instantiate(Card3S);
					else if(count3==1) cardobj = (GameObject)Instantiate(Card3H);
					else if(count3==2) cardobj = (GameObject)Instantiate(Card3C);
					else if(count3==3) cardobj = (GameObject)Instantiate(Card3D);
					count3++;
					break;}
			case 4:{
					if(count4==0) cardobj = (GameObject)Instantiate(Card4S);
					else if(count4==1) cardobj = (GameObject)Instantiate(Card4H);
					else if(count4==2) cardobj = (GameObject)Instantiate(Card4C);
					else if(count4==3) cardobj = (GameObject)Instantiate(Card4D);
					count4++;
					break;}
			case 5:{
					if(count5==0) cardobj = (GameObject)Instantiate(Card5S);
					else if(count5==1) cardobj = (GameObject)Instantiate(Card5H);
					else if(count5==2) cardobj = (GameObject)Instantiate(Card5C);
					else if(count5==3) cardobj = (GameObject)Instantiate(Card5D);
					count5++;
					break;}
			case 6:{
					if(count6==0) cardobj = (GameObject)Instantiate(Card6S);
					else if(count6==1) cardobj = (GameObject)Instantiate(Card6H);
					else if(count6==2) cardobj = (GameObject)Instantiate(Card6C);
					else if(count6==3) cardobj = (GameObject)Instantiate(Card6D);
					count6++;
					break;}
			case 7:{
					if(count7==0) cardobj = (GameObject)Instantiate(Card7S);
					else if(count7==1) cardobj = (GameObject)Instantiate(Card7H);
					else if(count7==2) cardobj = (GameObject)Instantiate(Card7C);
					else if(count7==3) cardobj = (GameObject)Instantiate(Card7D);
					count7++;
					break;}
			case 8:{
					if(count8==0) cardobj = (GameObject)Instantiate(Card8S);
					else if(count8==1) cardobj = (GameObject)Instantiate(Card8H);
					else if(count8==2) cardobj = (GameObject)Instantiate(Card8C);
					else if(count8==3) cardobj = (GameObject)Instantiate(Card8D);
					count8++;
					break;}
			case 9:{
					if(count9==0) cardobj = (GameObject)Instantiate(Card9S);
					else if(count9==1) cardobj = (GameObject)Instantiate(Card9H);
					else if(count9==2) cardobj = (GameObject)Instantiate(Card9C);
					else if(count9==3) cardobj = (GameObject)Instantiate(Card9D);
					count9++;
					break;}
			case 10:{
					if(count10==0) cardobj = (GameObject)Instantiate(Card10S);
					else if(count10==1) cardobj = (GameObject)Instantiate(Card10H);
					else if(count10==2) cardobj = (GameObject)Instantiate(Card10C);
					else if(count10==3) cardobj = (GameObject)Instantiate(Card10D);
					count10++;
					break;}
			case 11:{
					if(count11==0) cardobj = (GameObject)Instantiate(Card11S);
					else if(count11==1) cardobj = (GameObject)Instantiate(Card11H);
					else if(count11==2) cardobj = (GameObject)Instantiate(Card11C);
					else if(count11==3) cardobj = (GameObject)Instantiate(Card11D);
					count11++;
					break;}
			case 12:{
					if(count12==0) cardobj = (GameObject)Instantiate(Card12S);
					else if(count12==1) cardobj = (GameObject)Instantiate(Card12H);
					else if(count12==2) cardobj = (GameObject)Instantiate(Card12C);
					else if(count12==3) cardobj = (GameObject)Instantiate(Card12D);
					count12++;
					break;}
			case 13:{
					if(count13==0) cardobj = (GameObject)Instantiate(Card13S);
					else if(count13==1) cardobj = (GameObject)Instantiate(Card13H);
					else if(count13==2) cardobj = (GameObject)Instantiate(Card13C);
					else if(count13==3) cardobj = (GameObject)Instantiate(Card13D);
					count13++;
					break;}
			}

			float x,y,z;
			float tempDeg;
			Vector3 center = GameObject.Find("Center").transform.position;
			float degree = count * Mathf.PI * 2 / 13;//プレイヤーを中心とした、地面とカードがなす角？


			if (0 <= count && count <= 12) { //1段目
				y = 3.8f; // 高さ
				tempDeg = 0; //位置のずれを調整
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (14.036f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 5f;
			    z = Mathf.Sin (degree + tempDeg) * 5f;
			} else if (13 <= count && count <= 25) {//２段目
				y = 2.2f;
				tempDeg = Mathf.PI * 2 / 26; //Mathf = 円周率
			    cardobj.transform.rotation = Quaternion.Euler (new Vector3 (4.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
			    x = Mathf.Cos (degree + tempDeg) * 6f;
				  z = Mathf.Sin (degree + tempDeg) * 6f;
			} else if (26 <= count && count <= 38){//３段目
				y = 0.6f;
				tempDeg = 0;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (-6.764f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
				x = Mathf.Cos (degree + tempDeg) * 6f;
				z = Mathf.Sin (degree + tempDeg) * 6f;
			} else { // ad 4段目
				y = -1.0f;
				tempDeg = Mathf.PI * 2 / 26;
				cardobj.transform.rotation = Quaternion.Euler (new Vector3 (-16.034f, 270f - 180 * (degree + tempDeg) / Mathf.PI , 0f));
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

			//if(reversed[0] == ){


			Destroy(revesedObj[0]);
			Destroy(revesedObj[1]);

            HK app = GetComponent<HK>();
            app.appear(gameObject);

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
