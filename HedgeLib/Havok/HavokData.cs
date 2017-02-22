﻿using HedgeLib.Bases;
using System.Collections.Generic;

namespace HedgeLib.Havok
{
    public class HavokPackFile : FileBase
    {
        //Variables/Constants
        public Dictionary<string, HavokSection> Sections = new Dictionary<string, HavokSection>();
        public string ContentsVersion;
        public int ClassVersion;
    }

    public class HavokSection
    {
        //Variables/Constants
        public Dictionary<string, HavokObject> Objects = new Dictionary<string, HavokObject>();
    }

    public class HavokObject
    {
        //Variables/Constants
        public Dictionary<string, HavokParam> Parameters = new Dictionary<string, HavokParam>();
        public string Class, Signature;
    }

    public class HavokParam
    {
        //Variables/Constants
        public List<HavokObject> SubObjects = new List<HavokObject>();
        public List<object> Elements = new List<object>();
    }
}