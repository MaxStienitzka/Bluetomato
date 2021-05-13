using UnityEngine;

public class MenuSlide : MonoBehaviour
{
    float mousePosX;

    float mousePosXLast;

    float offsetX;
    Vector3 offset;
    public float sensibility;
    [SerializeField] GameObject Buttons;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosXLast = Input.mousePosition.x;
        }
        if (Input.GetMouseButton(0))
        {
            MoveSprite();
        }
        if (Input.GetMouseButtonUp(0))
        {
            mousePosXLast = 0;
        }
    }
    void MoveSprite()
    {
        mousePosX = Input.mousePosition.x;
        offsetX = mousePosX - mousePosXLast;
        offset = new Vector3(offsetX, 0, 0);
        Buttons.transform.position += offset / sensibility;
        mousePosXLast = Input.mousePosition.x;
  
    }
}