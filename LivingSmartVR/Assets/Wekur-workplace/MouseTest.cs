using UnityEngine;
using UnityEngine.InputSystem;
public class MouseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject controller; 
    void Start()
    {

    }

    void Update()
    {

        if(Keyboard.current.wKey.isPressed)
        {
            RaycastHit hit;

            Vector3 mouse = Mouse.current.position.ReadValue();
            //Vector3 vec = new Vector3(mouse.x, mouse.y, 300);
            mouse.z = -30;
            Debug.Log(mouse + " | " + transform.position);
            Debug.DrawRay(transform.position, mouse * 99999999, Color.red);

            if (Physics.Raycast(transform.position, mouse, out hit, 99999999))
                print("Found an object - distance: " + hit.distance);
        }

        //controller.transform.rotation = transform.position - controller.transform.position;




    }
}
