using UnityEngine;
using UnityEngine.Advertisements;
public class Adtest : MonoBehaviour
{
    public bool isFin = false;
    void Start()
    {
        Advertisement.Initialize("4222718");
    }
    public string m_result = string.Empty;

    /*private void OnGUI()
    {
        var options = new[]
                {
GUILayout.Width( Screen.width ),
GUILayout.Height( Screen.height / 2 ),
        };
        if (GUILayout.Button("Unity Ads", options))
        {
            ShowRewardedAd();
        }
        GUILayout.Label(m_result);
    }*/
    
    public void ShowRewardedAd()
    {
        if (!Advertisement.IsReady()) return;
        var options = new ShowOptions
        {
            resultCallback = OnResult,
        };
        Advertisement.Show(options);
    }
    public void OnResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                m_result = "Finished";
                isFin = true;
                break;
            case ShowResult.Skipped:
                m_result = "Skipped";
                isFin = true;
                break;
            case ShowResult.Failed:
                m_result = "Failed";
                isFin = true;
                break;
        }
    }
}