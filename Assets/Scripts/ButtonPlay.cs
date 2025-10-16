using System.Threading.Tasks;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private Transform _dollSpawnTransform;
    [SerializeField] private GameObject _playerDoll; 
    [SerializeField] private int _sceneIndex;
    [SerializeField] private float _delaySeconds;

    private bool _isActive = false;
    private async void OnMouseDown()
    {
        if(_isActive) return;
        
        _isActive = true;
        
        Instantiate(_playerDoll, _dollSpawnTransform.position,Quaternion.identity);
        
        await Task.Delay((int)(_delaySeconds * 1000));
        
        SceneLoadManager.LoadScene(_sceneIndex);
    }
}