﻿using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Store.Objects
{
    public class SniffData
    {
        public SniffFileInfo FileInfo = new SniffFileInfo();

        public double TimeStamp;

        public StoreNameType ObjectType = StoreNameType.None;

        public int Id = 0;

        public String Data = string.Empty;
    }
}