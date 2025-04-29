using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_c : MonoBehaviour
{
    public enum EName
    {
        Jen,
        Marc,
        Jose,
        Jessica
    }

    public EName name = EName.Jen;

    public string str_name;

    // Start is called before the first frame update
    void Start()
    {
        switch(name)
        {
            case EName.Jen: Debug.Log("My name is Jen"); break;
            case EName.Marc: Debug.Log("My name is Marc"); break;
            case EName.Jose: Debug.Log("My name is Jose"); break;
            case EName.Jessica: Debug.Log("My name is Jessica"); break;
            default: Debug.Log("My name is something"); break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
