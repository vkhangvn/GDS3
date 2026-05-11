using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursormanager : MonoBehaviour
{


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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

        }
    }
}
