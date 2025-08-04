using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IActiveCard
{
    public UnityEvent<Card> OnActive { get; }
    public void Active();
}

public interface IPassiveCard
{
    public UnityEvent<Card> OnPassive { get; }
    public void Passive();
}