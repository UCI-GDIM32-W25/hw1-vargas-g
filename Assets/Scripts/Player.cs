using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        // player moves up if holds or taps the "W" key.
        PlantSeed();
        if (Input.GetKey(KeyCode.W)) 
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        // player moves right if holds or taps the "D" key.
        if (Input.GetKey(KeyCode.D)) 
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        // player moves down if holds or taps the "S" key.
        if (Input.GetKey(KeyCode.S)) 
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        // player moves left if holds or taps the "A" key.
        if (Input.GetKey(KeyCode.A)) 
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
    }

    public void PlantSeed ()
    {
        // first checks to see if player even has any seeds available.
        if (_numSeedsLeft > 0)
        {
            // these lines allow for the plant prefab to show up at the player's location whenever the player presses on the spacebar.
            // "GetKeyDown" only triggers once instead of having that lingering string of seeds.
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
                // decreases value of seeds remaining.
                _numSeedsLeft--;
                // increases value of seeds planted.
                _numSeedsPlanted++;
                // calls UpdateSeeds() which updates seed text ui.
                _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            }
        }
    }
}
