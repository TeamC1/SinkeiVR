namespace sinkei
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;



    public class SpawnObj2 : MonoBehaviour
    {

        string HK = "Hk(Clone)";
        string DK = "Dk(Clone)";
        string SK = "Sk(Clone)";
        string CK = "Ck(Clone)";
        string HQ = "Hq(Clone)";
        string DQ = "Dq(Clone)";
        string SQ = "Sq(Clone)";
        string CQ = "Cq(Clone)";
        string HJ = "Hj(Clone)";
        string DJ = "Dj(Clone)";
        string SJ = "Sj(Clone)";
        string CJ = "Cj(Clone)";
        string hk = "王(ハート)";
        string dk = "王(ダイヤ)";
        string sk = "王(スペード)";
        string ck = "王(クラブ)";
        string hq = "女王(ハート)";
        string dq = "女王(ダイヤ)";
        string sq = "女王(スペード)";
        string cq = "女王(クラブ)";
        string hh = "HH";
        string ch = "CH";
        string dh = "DH";
        string sh = "SH";
        string you = "FPScontroller";

        private GameObject KH;
        private GameObject KD;
        private GameObject KS;
        private GameObject KC;
        private GameObject QH;
        private GameObject QD;
        private GameObject QS;
        private GameObject QC;
        private GameObject JH;
        private GameObject JD;
        private GameObject JS;
        private GameObject JC;


        public SpawnObj2()
        {
            KH = GameObject.Find(hk);
            KD = GameObject.Find(dk);
            KS = GameObject.Find(sk);
            KC = GameObject.Find(ck);
            QH = GameObject.Find(hq);
            QD = GameObject.Find(dq);
            QS = GameObject.Find(sq);
            QC = GameObject.Find(cq);
            JH = GameObject.Find(hh);
            JD = GameObject.Find(dh);
            JS = GameObject.Find(sh);
            JC = GameObject.Find(ch);
         }

        private void Start()
        {
           
            //StartCoroutine("Delay");
        }


        /*private IEnumerator Delay()
        {
            Debug.Log("in");
            yield return new WaitForSeconds(0.1f);
            
            Debug.Log("out");
         }
         */
    public void check (GameObject card)
        {
            Vector3 Loc = card.transform.position;
            Quaternion Rot = card.transform.rotation;
            string who = card.name;
            

            if (who == HK)
            {
                 var ef = Instantiate(KH);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");

            }
            if (who == DK)
            {

                var ef = Instantiate(KD);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == SK)
            {

                var ef = Instantiate(KS);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == CK)
            {

                var ef = Instantiate(KC);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == HQ)
            {

                var ef = Instantiate(QH);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.transform.Rotate(0,-90,0);
                ef.tag = ("clone");
            }
            if (who == DQ)
            {

                var ef = Instantiate(QD);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.transform.Rotate(0, -90, 0);
                ef.tag = ("clone");
            }
            if (who == SQ)
            {

                var ef = Instantiate(QS);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.transform.Rotate(0, -90, 0);
                ef.tag = ("clone");
            }
            if (who == CQ)
            {

                var ef = Instantiate(QC);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.transform.Rotate(0, -90, 0);
                ef.tag = ("clone");
            }
            if (who == HJ)
            {

                var ef = Instantiate(JH);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == DJ)
            {

                var ef = Instantiate(JD);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == SJ)
            {

                var ef = Instantiate(JS);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
            if (who == CJ)
            {

                var ef = Instantiate(JC);
                ef.transform.position = Loc;
                ef.transform.rotation = Rot;
                ef.tag = ("clone");
            }
        }

        /*
public GameObject DHut;
public GameObject CHut;
public GameObject SHut;
public GameObject HHut;
public GameObject DKing;
public GameObject CKing;
public GameObject SKing;
public GameObject HKing;
public GameObject DQueen;
public GameObject CQueen;
public GameObject SQueen;
public GameObject HQueen;


private void Start()
{

}

public class card
{
private string v;

public card(string v)
{
   this.v = v;
}

public string Num { get; set; }
}

private void Update()
{

}

public void Spawn(GameObject obj)
{

List<card> list = new List<card>();
list.Add(new card(obj.name));


List<string> s = list.ConvertAll(x => string.Format("Num", x.Num));

string HK = "Card13H";
string SK = "Card13S";
string CK = "Card13C";
string DK = "Card13D";

string HQ = "Card12H";
string SQ = "Card12S";
string CQ = "Card12C";
string DQ = "Card12Q";

string HJ = "Card11H";
string SJ = "Card11S";
string CJ = "Card11C";
string DJ = "Card11D";

GameObject cha = null;


if (obj.name == HK)
{
cha = (GameObject)Instantiate(HKing);
}
if (obj.name == DK)
{
cha = (GameObject)Instantiate(DKing);
}
if (obj.name == SK)
{
cha = (GameObject)Instantiate(SKing);
}
if (obj.name == CK)
{
cha = (GameObject)Instantiate(CKing);
}

if (obj.name == HQ)
{
cha = (GameObject)Instantiate(HQueen);
}
if (obj.name == DQ)
{
cha = (GameObject)Instantiate(DQueen);
}
if (obj.name == SQ)
{
cha = (GameObject)Instantiate(SQueen);
}
if (obj.name == CQ)
{
cha = (GameObject)Instantiate(CQueen);
}

if (obj.name == HJ)
{
cha = (GameObject)Instantiate(HHut);
}
if (obj.name == DJ)
{
cha = (GameObject)Instantiate(DHut);
}
if (obj.name == SJ)
{
cha = (GameObject)Instantiate(SHut);
}
if (obj.name == CJ)
{
cha = (GameObject)Instantiate(CHut);
}

Vector3 center = GameObject.Find("Center").transform.position;
cha.transform.position = new Vector3(0,0,0);
}
*/
    }
}