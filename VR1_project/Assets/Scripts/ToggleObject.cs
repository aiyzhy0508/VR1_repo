using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    // ������ �� ������, ������� ����� ��������������/����������������
    public GameObject targetObject;

    // �����, ������� ���������� ��� ������� ������
    public void Toggle()
    {
        // ���� ������ �������, ������������ ���, ����� ����������
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