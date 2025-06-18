using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickBehaviour : MonoBehaviour
{
    public int points = 1; // negative Zahl f�r Bomben

    void OnMouseDown()
    {
        Debug.Log("Sphere wurde angeklickt!");
        ScoreManager.Instance.AddPoints(points);
        Destroy(gameObject);
    }
}
