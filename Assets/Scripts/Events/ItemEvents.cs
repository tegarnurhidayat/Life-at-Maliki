using System;

public class ItemEvents
{
    public event Action<int> onItemGained;
    public void ItemGained(int item)
    {
        if (onItemGained != null)
        {
            onItemGained(item);
        }
    }

    public event Action<int> onItemChange;
    public void ItemChange(int item)
    {
        if (onItemChange != null)
        {
            onItemChange(item);
        }
    }
}
