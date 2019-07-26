using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlayerManager : MonoBehaviour
{
    private Animator Anims;
    // Start is called before the first frame update
    void Start()
    {
       Anims = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Back
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            Anims.Play("WalkAnimationBack");
        }
        //Front
        if (Input.GetAxis("Vertical") < 0.0f)
        {
            Anims.Play("WalkAnimationFront");
        }
        //Right
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            Anims.Play("WalkAnimationSide_2");
        }
        //Left
        if (Input.GetAxis("Horizontal") < 0.0f)
        {
            Anims.Play("WalkAnimationSide_2");
        }
    }
}
