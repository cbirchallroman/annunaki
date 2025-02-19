﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExporterCaravan : Caravan {

    public override void OnceAtDestination() {

        base.OnceAtDestination();

        //if amount at destination is less than needed, set order.num to that amount
        StorageBuilding strg = (StorageBuilding)Destination;
        if (Order.amount > strg.Inventory[Order.item])
            Order.amount = strg.Inventory[Order.item];

        //subtract what we're taking away from the inventory
        strg.Inventory[Order.item] -= Order.amount;

        money.Sheqels += (int)Order.ExchangeValue();


    }

}
