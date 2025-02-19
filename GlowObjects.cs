using UnityEngine;

public class GlowObjects : MonoBehaviour
{
    public Material myMaterial;
    public Color glowColor = Color.yellow;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer != null && myMaterial != null)
            {
                renderer.material = myMaterial;
                renderer.material.SetColor("_EmissionColor", glowColor);

                DynamicGI.SetEmissive(renderer, glowColor);
            }
        }
    }
}
