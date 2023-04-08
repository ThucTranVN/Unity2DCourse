using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingTest : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    private float value = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnDamage();
        }
    }

    private void OnDamage()
    {
        if (postProcessVolume.profile.TryGetSettings(out Vignette vignette))
        {
            value += 0.2f;
            value = Mathf.Clamp(value, 0, 0.6f);
            vignette.intensity.value = value;
        }
    }
}
