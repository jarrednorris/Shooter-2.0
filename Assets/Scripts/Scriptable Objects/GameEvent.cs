using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> m_listeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = 0; i < m_listeners.Count; i++)
            m_listeners[i].Raise();
    }

    public void AddListener(GameEventListener listener)
    {
        m_listeners.Add(listener);
    }

    public void RemoveListener(GameEventListener listener)
    {
        m_listeners.Remove(listener);
    }
}