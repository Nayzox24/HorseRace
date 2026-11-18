using UnityEngine;
using TMPro;
public class Scoreplayer : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private TextMeshProUGUI scoreText;
   
    void Update()
    {
        scoreText.text = "score : "+ transformPlayer.position.z.ToString("0");
    }
}
