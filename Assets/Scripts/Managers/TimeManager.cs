using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public float slowdownFactor;
    public float slowdownLength;
    bool isPaused;

    public TimeManager()
    {
        isPaused = false;
        slowdownFactor = .3f;
        slowdownLength = 2.0f;
        
    }

    public void GamePaused()
    {
        this.isPaused = true;
        
    }

    private void Pause()
    {
        if (this.isPaused)
        {
            Time.timeScale = 0f;
        }

        else
        {
            Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);

        }
    }
    public void Update()
    {
        Pause();
    }

    public void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }


}