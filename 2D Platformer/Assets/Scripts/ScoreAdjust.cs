using TMPro;
using UnityEngine;

public class ScoreAdjust : MonoBehaviour
{
    public TMP_Text m_text;
    private const string k_label = "Score: <#0080ff>{0}</color>";
    private float count;

    void Update()
    {
        if (PlayerInput.directionalInput.x != 0)
        {
            m_text.SetText(k_label, (int) count);
            count += 0.1f;
        }
    }

}
