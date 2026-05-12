using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormanager : MonoBehaviour
{

    [SerializeField] private Animator hand;
    private Vector2 cursorHotspot;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Get mouse position on screen
        Vector2 mousePositionOnScreen = Input.mousePosition;

        //Convert that to position in world
        Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);

        //Move myself to that position
        transform.position = new Vector3(mousePositionInWorld.x, mousePositionInWorld.y, 0);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            hand.SetBool("clicking", true);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            hand.SetBool("clicking", false);
        }
    }
}
