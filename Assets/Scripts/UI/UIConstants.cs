using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "UIConstants", menuName = "ScriptableObjects/UIConstants", order = 1)]
public class UIConstants : ScriptableObject
{
    public bool startMenuShown = true;
    public int m_NumRoundsToWin = 1;
    public bool redBlurActivated = false;
}
