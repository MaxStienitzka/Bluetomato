using UnityEngine;

public class MouseField2 : MonoBehaviour
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

    private void MoveSprite()
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

    public void EventStart()
    {
        mousePosXLast = Input.mousePosition.x;
    }

    public void EventCalled()
    {
        if (Input.GetMouseButton(0))
        {
            MoveSprite();
        }
    }

    public void EventFinished()
    {
        offsetX = 0;
    }
}
