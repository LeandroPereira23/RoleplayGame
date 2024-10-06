using Library.Items;
using Program;

namespace LibraryTests;

public class InventoryTest
{
    [Test]
    public void TestGetIndexOfItem()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(2);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        Hat hat = new Hat(10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        
        Assert.AreEqual(0, inventory.GetIndexOfItem(knife));
        Assert.AreEqual(1, inventory.GetIndexOfItem(spear));
        Assert.AreEqual(-1, inventory.GetIndexOfItem(hat));
    }
    
    [Test]
    public void TestItemAlreadyExists()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(2);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        Hat hat = new Hat(10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        
        Assert.AreEqual(true, inventory.ItemAlreadyExists(knife));
        Assert.AreEqual(true, inventory.ItemAlreadyExists(spear));
        Assert.AreEqual(false, inventory.ItemAlreadyExists(hat));
    }
    
    [Test]
    public void TestGetIndexSlotAvailable()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(2);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        Assert.AreEqual(-1, inventory.GetFirstIndexSlotAvailable());
        
        inventory.RemoveItem(knife);
        Assert.AreEqual(0, inventory.GetFirstIndexSlotAvailable());
    }
    
    [Test]
    public void TestIsSlotAvailable()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(3);
        Knife knife = new Knife(10);

        inventory.AddItem(knife);
        
        Assert.IsFalse(inventory.IsSlotAvailable(0));
        Assert.IsTrue(inventory.IsSlotAvailable(1));
        Assert.IsTrue(inventory.IsSlotAvailable(2));
    }
    
    [Test]
    public void TestAddItem()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(5);
        Knife knife = new Knife(10);
        Spear spear = new Spear(15);

        inventory.AddItem(knife);
        inventory.AddItem(spear);

        Assert.AreEqual(knife, inventory.Items[0]);
        Assert.AreEqual(spear, inventory.Items[1]);
        Assert.IsNull(inventory.Items[2]);
    }
    
    [Test]
    public void TestAddDuplicateItem()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(5);
        Knife knife = new Knife(10);
        
        inventory.AddItem(knife);
        inventory.AddItem(knife);
        
        Assert.AreEqual(knife, inventory.Items[0]);
        Assert.IsNull(inventory.Items[1]);
    }
    
    [Test]
    public void TestAddItemToFullInventory()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(4);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        Armor armor = new Armor(10);
        Hat hat = new Hat(10);
        Shield shield = new Shield(10, 10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        inventory.AddItem(armor);
        inventory.AddItem(hat);
        inventory.AddItem(shield);
        
        Assert.AreEqual(shield, inventory.Items[0]);
        Assert.AreEqual(knife, inventory.Items[1]);
        Assert.AreEqual(spear, inventory.Items[2]);
        Assert.AreEqual(armor, inventory.Items[3]);
        Assert.AreEqual(-1, inventory.GetIndexOfItem(hat));
    }

    [Test]
    public void TestAddItemToMiddleSlotAfterRemoval()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(4);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        Armor armor = new Armor(10);
        Hat hat = new Hat(10);
        Shield shield = new Shield(10, 10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        inventory.AddItem(armor);
        inventory.AddItem(hat);
        
        Assert.AreEqual(armor, inventory.Items[2]);
        inventory.RemoveItem(armor);
        Assert.IsNull(inventory.Items[2]);
        inventory.AddItem(shield);
        Assert.AreEqual(shield, inventory.Items[2]);
    }
    
    [Test]
    public void TestRemoveItem()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(5);
        Knife knife = new Knife(10);
        inventory.AddItem(knife);
        inventory.RemoveItem(knife);

        Assert.IsNull(inventory.Items[0]);
    }
    
    [Test]
    public void TestClearInventory()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(4);
        Knife knife = new Knife(10);
        Spear spear = new Spear(10);
        Armor armor = new Armor(10);
        Hat hat = new Hat(10);
        
        inventory.AddItem(knife);
        inventory.AddItem(spear);
        inventory.AddItem(armor);
        inventory.AddItem(hat);

        inventory.ClearInventory();
        
        Assert.IsNull(inventory.Items[0]);
        Assert.IsNull(inventory.Items[1]);
        Assert.IsNull(inventory.Items[2]);
        Assert.IsNull(inventory.Items[3]);
    }
    
    [Test]
    public void TestGetItemNames()
    {
        Inventory<IPhysicItem> inventory = new Inventory<IPhysicItem>(3);
        Knife knife = new Knife(10);
        Spear spear = new Spear(15);

        inventory.AddItem(knife);
        inventory.AddItem(spear);

        string[] itemNames = inventory.GetItemNames();
        
        Assert.AreEqual("Knife", itemNames[0]);
        Assert.AreEqual("Spear", itemNames[1]);
        Assert.IsNull(itemNames[2]);
    }
}