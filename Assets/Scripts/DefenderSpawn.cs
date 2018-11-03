using UnityEngine;
using System.Collections;

public class DefenderSpawn : MonoBehaviour {

	// Use this for initialization
	public Camera mycamera;
	private GameObject DefenderParent;
	private StarDisplay  stardisplay;
	void Start () 
	{
		stardisplay=GameObject.FindObjectOfType<StarDisplay>();
		DefenderParent=GameObject.Find("Defenders");
		if(!DefenderParent)
		{
			DefenderParent=new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
	   Vector2 rawpos=CalculateWorldPointofMouseClick();
	   Vector2 pos = SnaptoGrid(rawpos);
	   GameObject seleccteddefender=Button.SelectedDefender;
	   int defendercost=seleccteddefender.GetComponent<Defender>().cost;
	   if(stardisplay.Usestars(defendercost)==StarDisplay.Status.SUCCESS)
	   {
			GameObject newattacker=Instantiate(seleccteddefender,pos,Quaternion.identity) as GameObject;
	   newattacker.transform.parent=DefenderParent.transform;
	   }
		
//	   print (Input.mousePosition);
//		print (SnaptoGrid(CalculateWorldPointofMouseClick()));
	}
	Vector2 SnaptoGrid(Vector2 rawpos)
	{
	   float newx=Mathf.Round(rawpos.x);
	   float newy=Mathf.Round(rawpos.y);
		Vector2 pos=new Vector2(newx,newy);
		return pos;
	}
	Vector2 CalculateWorldPointofMouseClick()
	{
	  float mousex=Input.mousePosition.x;
	  float mousey=Input.mousePosition.y;
	  float distancefromcamera=10f;
	  Vector3 wierdtriplet= new Vector3(mousex,mousey,distancefromcamera);
	  Vector2 worldpos=mycamera.ScreenToWorldPoint(wierdtriplet);
		return  worldpos;
	}
}
