using UnityEngine;

public class Paralax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float aniamtionSPeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(aniamtionSPeed * Time.deltaTime, 0);
    }
}