using UnityEngine;

public class Singletone<T> where T : new()
{
    static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}

public class MonoSingletone<T> : MonoBehaviour where T : MonoBehaviour
{
    static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var go = new GameObject();
                instance = go.AddComponent<T>();
                GameObject.DontDestroyOnLoad(go);
            }
            return instance;
        }
    }
}