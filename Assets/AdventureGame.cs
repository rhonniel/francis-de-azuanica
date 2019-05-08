using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingTate;
   



    State state;
    int items = 0;

	// Use this for initialization
	void Start () {
        state = startingTate;
        textComponent.text = state.GetStateStory();
     
     

    }
	
	// Update is called once per frame
	void Update () {
        ManageState();
        
	}

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

       

        if (state.stateEnd())
        {

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = nextStates[items];
            }
                
            
        }
        else
        {
            for (int i = 0; i < nextStates.Length; i++)
            {

                if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                {
                    if (state.stateInit())
                    {
                        items = 0;
                    }

                    if (state.stateHaveItem())
                    {
                        items++;
                    }
                    state = nextStates[i];
                }

            }
        }

        
     

        textComponent.text = state.GetStateStory();
    }

}
