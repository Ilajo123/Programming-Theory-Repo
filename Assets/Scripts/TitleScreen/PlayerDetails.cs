using UnityEngine;

public class PlayerDetails : MonoBehaviour
{
    public string playerName;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
