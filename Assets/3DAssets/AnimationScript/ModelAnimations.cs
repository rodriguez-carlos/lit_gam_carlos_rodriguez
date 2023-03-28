using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAnimations : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CharacterModel;

    private void ExecuteTriggerFromUI(string trigger)
    {
        if (CharacterModel != null)
        {
            var animator = CharacterModel.GetComponent<Animator>();
            if(animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }

    public void DanceTheMacarena()
    {
        ExecuteTriggerFromUI("TrMacarena");
    }
    public void DanceTheHouse()
    {
        ExecuteTriggerFromUI("TrHouse");
    }
    public void DanceTheHipHop()
    {
        ExecuteTriggerFromUI("TrHipHop");
    }
}
