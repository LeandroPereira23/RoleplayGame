namespace Library.Items;

public class Inventory<TItem>
{
    protected TItem[] items;
    public TItem[] Items
    {
        get { return Items; }
    }
    
    private int inventoryLength;
    public int InventoryLength
    {
        get { return inventoryLength; }
    }
    
    public Inventory(int inventoryLength)
    {
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
            // Reemplazar el peor item
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
}