using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    public float speed = 1f;
    private float rotation = 0f;

    void Update()
    {
        rotation += speed * Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Rotation", rotation);
    }
}
