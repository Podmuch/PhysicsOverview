using UnityEngine;
using System.Collections;

public class SpringLine : MonoBehaviour
{
    public Transform Sphere;
    public LineRenderer Renderer;

    private void Update()
    {
        Renderer.SetPosition(1, new Vector3(0.3f, Sphere.position.y, 0));
    }
}
