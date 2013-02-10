﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using GameBotGUI.Record.Types.Click;

namespace GameBotGUI.Record
{
    abstract class RecordBase
    {
        public RecordType Type { get; set; }
        public String Display { get { return ToString(); } }

        public RecordBase(RecordType type)
        {
            Type = type;
        }

        public virtual new String ToString()
        {
            return Type.ToString();
        }

        public virtual object Clone()
        {
            return null;
        }
    }
}
