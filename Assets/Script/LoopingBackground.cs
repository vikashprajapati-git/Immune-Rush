using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float backgroundSpeed;
    [SerializeField] Renderer backgroundRendrer;

    void Update()
    {
        backgroundRendrer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
