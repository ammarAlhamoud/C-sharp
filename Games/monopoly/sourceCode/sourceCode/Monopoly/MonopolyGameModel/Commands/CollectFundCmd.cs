﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonopolyGameModel.Model;

namespace MonopolyGameModel.Commands
{
    public class CollectFundCmd : ACommand
    {
        public CollectFundCmd(APlayer player):base(player)
        {

        }
    }
}