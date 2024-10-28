﻿using System;

namespace Facade
{
    public class InventoryManager
    {
        public void Update(int productId)
        {
            Console.WriteLine($"Product# {productId} is subtracted from the store's inventory");
        }
    }
}
