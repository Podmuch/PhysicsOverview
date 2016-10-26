using UnityEngine;

public class Shapecaster : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit[] hitObjects = Physics.SphereCastAll(transform.position, 5, Vector3.forward);
            Debug.LogWarning(hitObjects.Length + " objects are in the range");
            Debug.Draw
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawSphere(transform.position, 5);
    }
}