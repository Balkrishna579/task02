using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using ROSBridgeLib;
using SimpleJSON;
using ROSBridgeLib.Move;

public class subs : MonoBehaviour
{
   public static GameObject game;
    public static Rigidbody rb;

        
       public static long k;
        public static long s;
        
    public new static string GetMessageTopic() {
   
    return "/formove";
  }

  public new static string GetMessageType() {
   
    return "move/Num";
  }

  
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new Num (msg);
  }

  
  public new static  void CallBack(Num msg) {
    
    Debug.Log("Recieved Message : "+msg.ToYAMLString());
    game=GameObject.Find("Cube");
     rb=game.GetComponent<Rigidbody>();
    
    k=msg.Getnum2();
    s=msg.Getnum();
     if(s==8){
           Debug.Log(s);
           rb.AddForce(game.transform.forward*k);}

           else if(s==2){
          rb.AddForce(0,0,1*k,ForceMode.Impulse);
     }else if(s==4){
          rb.AddForce(k,0,0,ForceMode.Impulse);
     }else if(s==6){
          rb.AddForce(-1*k,0,0,ForceMode.Impulse);
     }else if(s==5){
          rb.AddForce(0,k,0,ForceMode.Impulse);}
    
    }
     
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
           
        
    }
}
