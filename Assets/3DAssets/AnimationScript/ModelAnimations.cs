using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModelAnimations : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CharacterModel;
    [SerializeField] private TMP_Text fourthButtonText;

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

    public void FormatAdvanceButton(string danceName)
    {
        fourthButtonText.text = $"Play with {danceName}";
    }
    public void DanceTheMacarena()
    {
        ExecuteTriggerFromUI("TrMacarena");
        FormatAdvanceButton("The Macarena");
    }
    public void DanceTheHouse()
    {
        ExecuteTriggerFromUI("TrHouse");
        FormatAdvanceButton("House");

    }
    public void DanceTheHipHop()
    {
        ExecuteTriggerFromUI("TrHipHop");
        FormatAdvanceButton("Hip Hop");

    }
}
