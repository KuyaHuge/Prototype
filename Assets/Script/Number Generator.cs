using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // This function is called when the object is clicked
    private void OnMouseDown()
    {
        Debug.Log("Object clicked.");
        // Add your interaction logic here if needed

        // Deactivate or destroy the object
        gameObject.SetActive(false); // Deactivate the GameObject
        // OR
        // Destroy(gameObject); // Destroy the GameObject
    }
}