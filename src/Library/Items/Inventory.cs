namespace Library.Items;

public class Inventory<TItem>
{
    private TItem[] items;
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
        if (inventoryLength <= 0)
        {
            throw new ArgumentException("Inventory length must be greater than zero.");
        }
        this.inventoryLength = inventoryLength;
        items = new TItem[inventoryLength];
    }
    
    public bool ItemAlreadyExists(TItem item)
    {
        return Array.IndexOf(items, item) != -1;
    }

    public int GetFirstIndexSlotAvailable()
    {
        for (int i = 0; i < inventoryLength; i++)
        {
            if (IsSlotAvailable(i)) return i;
        }
        
        return -1;
    }

    public bool IsSlotAvailable(int index)
    {
        return items[index] == null;
    }
    
    public int GetIndexOfItem(TItem item)
    {
        return Array.IndexOf(items, item);
    }
    
    public void AddItem(TItem item)
    {
        if (ItemAlreadyExists(item)) return;

        int indexSlotAvailable = GetFirstIndexSlotAvailable();
        if (indexSlotAvailable != -1)
        {
            AssignItemToSlot(indexSlotAvailable, item);
        }
        else
        {
            for (int i = inventoryLength - 1; i > 0; i--)
            {
                items[i] = items[i - 1];
            }
            
            items[0] = item;
        }
    }
    
    public void RemoveItem(TItem item)
    {
        int index = GetIndexOfItem(item);
        if (index == -1) return;
        
        items[index] = default;
    }
    
    public void ClearInventory()
    {
        items = new TItem[inventoryLength];
    }

    public string[] GetItemNames()
    {
        string[] names = new string[inventoryLength];
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
            {
                names[i] = items[i].GetType().Name;
            }
        }
        return names;
    }
    
    private void AssignItemToSlot(int index, TItem item)
    {
        items[index] = item;
    }
}