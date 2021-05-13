using UnityEngine;

public class MouseField : MonoBehaviour
{
    public float mousePosX;

    public float mousePosXLast;

    public float offsetX;

    public float sensibility;

    public float offset;

    float smoothroatet = 5f;

    [SerializeField]
    GameObject skateboard;

    void Start()
    {
        mousePosXLast = Input.mousePosition.x;
    }

    public void EventCalled()
    {
        offsetX = mousePosX - mousePosXLast;
        offset += offsetX / sensibility;
        skateboard.transform.rotation =
            Quaternion
                .Lerp(transform.rotation,
                Quaternion.Euler(0, -offset, 0),
                smoothroatet);
        mousePosXLast = Input.mousePosition.x;
    }
}
