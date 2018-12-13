using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionalEvent : MonoBehaviour
{
    public UnityEvent onConditionMet, onNotConditionMet;

    public IntVariable intVar;
    public int conditionValue;

    public enum Condition { GreaterThan, LessThan, GreaterThanOrEqualTo, LessThanOrEqualTo, EqualTo, NotEqualTo }
    public Condition condition;

    public void TestCondition()
    {
        bool conditionMet = false;
        switch (condition)
        {
            case Condition.GreaterThan:
                conditionMet = (intVar.RuntimeValue > conditionValue);
                break;
            case Condition.LessThan:
                conditionMet = (intVar.RuntimeValue < conditionValue);
                break;
            case Condition.GreaterThanOrEqualTo:
                conditionMet = (intVar.RuntimeValue >= conditionValue);
                break;
            case Condition.LessThanOrEqualTo:
                conditionMet = (intVar.RuntimeValue <= conditionValue);
                break;
            case Condition.EqualTo:
                conditionMet = (intVar.RuntimeValue == conditionValue);
                break;
            case Condition.NotEqualTo:
                conditionMet = (intVar.RuntimeValue != conditionValue);
                break;
        }
        if (conditionMet)
            onConditionMet.Invoke();
        else
            onNotConditionMet.Invoke();
    }
}
