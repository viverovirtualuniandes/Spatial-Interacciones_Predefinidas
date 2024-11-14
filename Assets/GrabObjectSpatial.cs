using UnityEngine;

public class GrabObjectSpatial : MonoBehaviour
{
    private bool isGrabbed = false;
    private Transform originalParent;
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    void Start()
    {
        originalParent = transform.parent;
        originalPosition = transform.localPosition;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        if (isGrabbed)
        {
            // Actualiza la posición del objeto para que siga al controlador o cursor del usuario
            // Esto dependerá de cómo manejes la entrada del usuario en tu proyecto
        }
    }

    public void OnGrab()
    {
        isGrabbed = true;
        transform.SetParent(null); // Desvincula el objeto de su padre original
        GetComponent<Rigidbody>().isKinematic = true; // Desactiva la física mientras se agarra
    }

    public void OnRelease()
    {
        isGrabbed = false;
        transform.SetParent(originalParent); // Vuelve a vincular el objeto a su padre original
        transform.localPosition = originalPosition; // Restablece la posición original
        transform.localRotation = originalRotation; // Restablece la rotación original
        GetComponent<Rigidbody>().isKinematic = false; // Reactiva la física
    }
}
