using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;
        if (keyboard.wKey.isPressed)
        {
            Debug.Log("W Pressed");
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (keyboard.aKey.isPressed)
        {
            Debug.Log("A Pressed");
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (keyboard.dKey.isPressed)
        {
            Debug.Log("D Pressed");
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (keyboard.sKey.isPressed)
        {
            Debug.Log("S Pressed");
            transform.Translate(Vector3.back * Time.deltaTime);
        }
    }
}
