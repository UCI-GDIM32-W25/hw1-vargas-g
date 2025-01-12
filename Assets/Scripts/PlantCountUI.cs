using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        // Displays text of seeds which player has planted.
        _plantedText.text = seedsPlanted.ToString();
        // Displays text of the seeds which player can still plant.
        _remainingText.text = seedsLeft.ToString();
    }
}