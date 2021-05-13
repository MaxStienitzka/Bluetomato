using System.Data;
using UnityEngine;

public class DragRotate : MonoBehaviour
{
    public float mousePosX;

    // float mousePosY;
    public float mousePosXLast;

    // float mousePosYLast;
    public float offsetX;

    //float offsetY;
    public float sensibility;

    public float offset;

    float smoothroatet = 5f;

    [SerializeField]
    GameObject map;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosXLast = Input.mousePosition.x;
            //mousePosYLast = Input.mousePosition.y;
        }
        if (Input.GetMouseButton(0))
        {
            MoveSprite();
        }
    }

    void MoveSprite()
    {
        mousePosX = Input.mousePosition.x;
        offsetX = mousePosX - mousePosXLast;
        offset += offsetX / sensibility;
        map.transform.rotation =
            Quaternion
                .Lerp(transform.rotation,
                Quaternion.Euler(0, -offset, 0),
                smoothroatet);
        mousePosXLast = Input.mousePosition.x;
    }
}
