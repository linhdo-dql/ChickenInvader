
using UnityEngine;

public class GameController : MonoBehaviour
{    
    public enum GameState
    {
        Home, 
        Play, 
        GameOver
    }
    private GameState _currentState;
    public void InstantiateObj(GameObject obj, Vector3 vector3)
    {
        Instantiate(obj, vector3, obj.transform.rotation);
    }

    public void DestroyObjAfterTime(GameObject obj, float time)
    {
        Destroy(obj, time);
    }

    public void SetState(GameState _nextState, GameState _currentState)
    {
        _currentState = _nextState;
    }

    public void UpdateHp(GameObject gameObject, int Hp)
    {
        
    }
}
