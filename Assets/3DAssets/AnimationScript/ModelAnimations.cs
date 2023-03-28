using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator mAnimator;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("TrHouse");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
