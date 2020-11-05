﻿using System;
using System.Threading.Tasks;

namespace Albion.Network.Example
{
    public class NewCharacterEventHandler : EventPacketHandler<NewCharacterEvent>
    {
        public NewCharacterEventHandler() : base(25) { }

        protected override Task OnActionAsync(NewCharacterEvent value)
        {
            Console.WriteLine($"New ch Id: {value.Id}");

            return Task.CompletedTask;
        }
    }
}
