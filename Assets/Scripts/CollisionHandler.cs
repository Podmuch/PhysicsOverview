using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    #region COLLISIONS

    public bool CollisionLogger;

    private void OnCollisionEnter(Collision collision)
    {
        if (CollisionLogger) Debug.LogWarning(collision.collider.name + " touched " +gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (CollisionLogger) Debug.LogWarning(collision.collider.name + " is touching " + gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (CollisionLogger) Debug.LogWarning(collision.collider.name + " no longer touch " + gameObject.name);
    }

    #endregion

    #region TRIGGERS

    public bool TriggerLogger;

    void OnTriggerEnter(Collider other)
    {
        if (TriggerLogger) Debug.LogWarning(other.name + " entered into " + gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        if (TriggerLogger) Debug.LogWarning(other.name + " overlap " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        if (TriggerLogger) Debug.LogWarning(other.name + " left " + gameObject.name);
    }

    #endregion
}