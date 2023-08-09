/*****************************************************************************
* Project: GunFactory
* File   : AnimationEvent.cs
* Date   : 26.08.2021
* Author : Jan Apsel (JA)
*
* These coded instructions, statements, and computer programs contain
* proprietary information of the author and are protected by Federal
* copyright law. They may not be disclosed to third parties or copied
* or duplicated in any form, in whole or in part, without the prior
* written consent of the author.
*
* History:
*   23.08.2021	JA	Created
******************************************************************************/
using UnityEngine;

/// <summary>
/// Triggers IAction events
/// </summary>
public class AnimationEvent : MonoBehaviour
{
    [SerializeField] GameObject mReceiver;
    IAction[] mActions;
    private void Awake()
    {
        mActions = mReceiver.GetComponents<IAction>();
    }
    public void TriggerEvent()
    {
        foreach(IAction action in mActions)
            action.ExecuteAction();
    }
}
