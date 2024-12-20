using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    // Ссылка на объект, который будет активироваться/деактивироваться
    public GameObject targetObject;

    // Метод, который вызывается при нажатии кнопки
    public void Toggle()
    {
        // Если объект активен, деактивируем его, иначе активируем
        if (targetObject.activeSelf)
        {
            targetObject.SetActive(false);
        }
        else
        {
            targetObject.SetActive(true);
        }
    }
}