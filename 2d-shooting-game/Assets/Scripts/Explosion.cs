using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void OnAnimationFinish()
    {
        Destroy(gameObject);
    }
}