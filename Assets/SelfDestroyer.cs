using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelfDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    public bool time_flag=false;
    public float time=0;
    public bool bounds_flag=false;
    public float[] bounds;
    

    private float current_time = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(time_flag==true){
            checkedTime();
        }
        if(bounds_flag==true){
            checkedBound();
        }
    }

    void checkedTime()
    {
        current_time+=Time.deltaTime;
        if(current_time>=time){
            DestroySelf();
        }
    }

    void checkedBound()
    {
        var x = this.transform.position[0];
        var y = this.transform.position[1];
        if(bounds.Length == 4){
            if( x < bounds[0] || x > bounds[1] || y > bounds[2] || y < bounds[3]){
                DestroySelf();
            }          
        }
    }

    void DestroySelf(){
        GameObject.Destroy(this.gameObject);
    }
}
