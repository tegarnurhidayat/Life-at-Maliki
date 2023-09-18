using System;

public class StatEvents
{
    public event Action<int> onExperience1Gained;
    public void Experience1Gained(int experience)
    {
        if (onExperience1Gained != null)
        {
            onExperience1Gained(experience);
        }
    }

    public event Action<int> onPlayerLevel1Change;
    public void PlayerLevel1Change(int level)
    {
        if (onPlayerLevel1Change != null)
        {
            onPlayerLevel1Change(level);
        }
    }

    public event Action<int> onPlayerExperience1Change;
    public void PlayerExperience1Change(int experience)
    {
        if (onPlayerExperience1Change != null)
        {
            onPlayerExperience1Change(experience);
        }
    }

    public event Action<int> onExperience2Gained;
    public void Experience2Gained(int experience)
    {
        if (onExperience2Gained != null)
        {
            onExperience2Gained(experience);
        }
    }

    public event Action<int> onPlayerLevel2Change;
    public void PlayerLevel2Change(int level)
    {
        if (onPlayerLevel2Change != null)
        {
            onPlayerLevel2Change(level);
        }
    }

    public event Action<int> onPlayerExperience2Change;
    public void PlayerExperience2Change(int experience)
    {
        if (onPlayerExperience2Change != null)
        {
            onPlayerExperience2Change(experience);
        }
    }

    public event Action<int> onExperience3Gained;
    public void Experience3Gained(int experience)
    {
        if (onExperience3Gained != null)
        {
            onExperience3Gained(experience);
        }
    }

    public event Action<int> onPlayerLevel3Change;
    public void PlayerLevel3Change(int level)
    {
        if (onPlayerLevel3Change != null)
        {
            onPlayerLevel3Change(level);
        }
    }

    public event Action<int> onPlayerExperience3Change;
    public void PlayerExperience3Change(int experience)
    {
        if (onPlayerExperience3Change != null)
        {
            onPlayerExperience3Change(experience);
        }
    }
}
