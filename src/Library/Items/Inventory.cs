namespace Library.Items;

public class Inventory<TItem>
{
    protected TItem[] items;
    public TItem[] Items
    {
        get { return items; }
    }
    
    private int inventoryLength;
    public int InventoryLength
    {
        get { return inventoryLength; }
    }
    
    public Inventory(int inventoryLength)
    {
        this.inventoryLength = inventoryLength;
        items = new TItem[inventoryLength];
    }
    
    private int SearchItemInItems(TItem item)
    {
        return Array.IndexOf(items, item);
    }

    public void AddItem(TItem item)
    {
        if (ItemAlreadyExists(item)) return;

        int indexSlotAvailable = GetIndexSlotAvailable();
        if (indexSlotAvailable != -1)
        {
            AssignItemToSlot(indexSlotAvailable, item);
        }
        else
        {
            items[0] = item;
            for (int i = 0; i < items.Length; i++)
            {
                if (i == inventoryLength - 1)
                {
                    items[0] = items[i];
                }
                else
                {
                    items[i + 1] = items[i];
                }
            }
        }
    }

    private bool ItemAlreadyExists(TItem item)
    {
        return Array.IndexOf(items, item) != -1;
    }

    private int GetIndexSlotAvailable()
    {
        for (int i = 0; i < inventoryLength; i++)
        {
            if (IsSlotAvailable(i)) return i;
        }
        
        return -1;
    }

    private bool IsSlotAvailable(int index)
    {
        return items[index] == null;
    }
    
    private void AssignItemToSlot(int index, TItem item)
    {
        items[index] = item;
    }
    
    public void RemoveItem(TItem item)
    {
        items[SearchItemInItems(item)] = default(TItem);
    }

    public string[] GetItemNames()
    {
        string[] names = new string[inventoryLength];
        for (int i = 0; i < items.Length; i++)
        {
            names[i] = items[i].GetType().Name;
        }
        return names;
    }
}