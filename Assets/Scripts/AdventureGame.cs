using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent = null;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("You wake up in a dark cave with a shaft of light coming through the ceiling that you now recall falling through. \"Great!\", you think to yourself. \"I've really gotten myself in trouble now.\"");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
