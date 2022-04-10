/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Models
{
    public class Attribute
    {
        private string name;
        private Dictionary<string, string> attributes;

        public Attribute()
        {
            this.name = "";
            this.attributes = new Dictionary<string, string>();

    }
    public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void AddAttribute(string key, string value)
        {
            this.attributes.Add(key, value);
        }
        public Dictionary<string, string> GetAttributes()
        {
            return this.attributes;
        }
        public string GetAttribute(string key)
        {
            return this.attributes[key];
        }
    }
}
