using UnityEngine;

public class MoveMap : MonoBehaviour
{

    float mousePosX;
    float mousePosY;

    float mousePosXLast;
    float mousePosYLast;

    float offsetX;
    float offsetY;
    Vector3 offset;
    public float sensibility;
    [SerializeField] GameObject map;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosXLast = Input.mousePosition.x;
            mousePosYLast = Input.mousePosition.y;
        }
        if (Input.GetMouseButton(0))
        {
            MoveSprite();
        }
        if (Input.GetMouseButtonUp(0))
        {
            mousePosXLast = 0;
            mousePosYLast = 0;
        }
    }
    void MoveSprite()
    {
        mousePosX = Input.mousePosition.x;
        mousePosY = Input.mousePosition.y;
        offsetX = mousePosX - mousePosXLast;
        offsetY = mousePosY - mousePosYLast;
        offset = new Vector3(offsetX, offsetY, 0);
        map.transform.position += offset / sensibility;
        mousePosXLast = Input.mousePosition.x;
        mousePosYLast = Input.mousePosition.y;
    }
}