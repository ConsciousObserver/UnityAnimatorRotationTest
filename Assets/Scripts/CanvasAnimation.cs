using UnityEngine;
using System.Collections;

public class CanvasAnimation : MonoBehaviour {
    Animator animator;
    int currentFrame = 0;
    int frameCount = 6;

    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            if(currentFrame == 0)
            {
                animator.SetTrigger("start");
                //Debug.Log("Started");
            }
            currentFrame = (currentFrame + 1) % frameCount;

            animator.speed = 1;
        }
	}

    public void Handle()
    {
        animator.speed = 0;
        //Debug.Log("handeled");
    }
}
