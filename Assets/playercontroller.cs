using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerrb;
   private GameMnager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.FindGameObjectWithTag("gm").GetComponent<GameMnager>();
        playerrb=GetComponent<Rigidbody>();
        playerrb.position=new Vector3(gm.row-gm.row,transform.position.y,gm.column-gm.column);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W)){
           if (transform.position.z<gm.column-2)
           {
               transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z+2);
           }
           
           //transform.Translate(Vector3.forward*1*Time.deltaTime);
       }
       if(Input.GetKeyDown(KeyCode.S)){
           if(transform.position.z>0){
           transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z-2);
       }
       }
       if (Input.GetKeyDown(KeyCode.A))
       {
           if(transform.position.x>0){
           transform.position=new Vector3(transform.position.x-2,transform.position.y,transform.position.z);
       }
       }
       if (Input.GetKeyDown(KeyCode.D))
       {
           if(transform.position.x<gm.row-2){
           transform.position=new Vector3(transform.position.x+2,transform.position.y,transform.position.z);
       }
       }
    }
}
