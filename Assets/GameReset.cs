using UnityEngine;
using UnityEngine.SceneManagement;

public class DoodleJumpGame : MonoBehaviour
{
    public Transform player; 
    public Transform resetStripe; //chosen object
    public float resetThreshold = 5f;

    private Vector3 iPosition;

    void Start()
    {
        iPosition = player.position; 
    }

    void Update()
    {
        if (player.position.y < resetStripe.position.y - resetThreshold)
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}