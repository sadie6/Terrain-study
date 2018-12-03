using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {

    private Animator zombie_animator;
    public GameObject player;
    private CharacterController zombies;

   


    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
        zombie_animator = this.GetComponent<Animator>();
        zombies = this.GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void Update()
    {
        //print(speed);
        
        Vector3 targetPos = player.transform.position;     
        targetPos.y = transform.position.y;          //y轴为自己
        transform.transform.LookAt(targetPos);       //僵尸锁定目标
        float d = Vector3.Distance(targetPos, transform.position);     //僵尸和目标的距离
        if (d>12)               
        {
            speed = 0.5f;
            zombie_animator.SetBool("walk", false);    //离目标超过12m 则不播放走路动画
        }
        else
        {
            if (d > 1.4)
            {
                speed += 0.02f;    //随着时间推移，僵尸速度越来越快
                zombie_animator.SetBool("attack", false);   
                zombies.SimpleMove(transform.forward * (speed%6));   //速度超过6，则从头开始加速
                zombie_animator.SetBool("walk", true);
            }
            else
            {
                speed = 0.5f;
                zombie_animator.SetBool("attack", true);     //到达攻击距离，播放攻击动画
            }
            
        }
    }

   void Behit()     //僵尸被攻击
    {
        speed = 0.5f;
        zombies.SimpleMove(-transform.forward*25);    //向后移动一段距离
        //transform.Translate(new Vector3(transform.position.x,transform.position.y,transform.position.z-1));
    }




}
