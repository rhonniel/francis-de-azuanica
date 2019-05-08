using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*este comando de abajo hace que puedas crear una nueva opcion de objeto
 para el menu de Unity Asset, con la instruccion de abajo se añade la opcion
 de crear un objeto tipo State */
[CreateAssetMenu(menuName ="State")]

public class State : ScriptableObject {

    /*por lo visto cuando utiliza los corchetes estas de algun podo comunicandote 
     con la interfaz de unity, esta manipulando la forma  en que unity 
     representara el campo*/

     /*este caso se esta representado al objeto como une text area, 
      el primer parametro representa el tamaño que sera visible y el otro representa
      el tamaño del scroll
        
         */
   
    

    [TextArea(14,10)] [SerializeField] string storyText;

    [TextArea(7, 7)] [SerializeField] string type;

    [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

    public bool stateHaveItem()
    {
        if(type == null)
        {
            return false;
        }

        type = type.Trim();
        if (type == "I")
        {
            return true;
        } else
        {
            return false;
        }
        
    }

    public bool stateInit()
    {

        if (type == null)
        {
            return false;
        }
        type = type.Trim();
        if (type == "A")
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public bool stateEnd()
    {

        if (type == null)
        {
            return false;
        }

        type = type.Trim();
        if (type == "E")
        {
            return true;
        }
        else
        {
            return false;
        }


    }

}
