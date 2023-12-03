using UnityEngine;

public class LiftObjectOnSelection : MonoBehaviour, ISelectionResponse
{
    private Vector3 initialPosition;
    private bool isLifted = false;

    public void OnSelect(Transform selection)
    {
        if (selection != null)
        {
            initialPosition = selection.position;
            selection.position += new Vector3(0f, 1f, 0f);
            isLifted = true;
        }
    }

    public void OnDeselect(Transform selection)
    {
        if (isLifted && selection != null)
        {
            selection.position = initialPosition;
            isLifted = false;
        }
    }
}
