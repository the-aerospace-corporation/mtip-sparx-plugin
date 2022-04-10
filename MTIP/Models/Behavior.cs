/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node behavior metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Models
{
    public class Behavior
    {
        private string name;
        private string type;
        private string value;
        public Behavior()
        {
           
        }
        public Behavior(string name, string type, string value)
        {
            this.name = name;
            this.type = type;
            this.value = value;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetType(string type)
        {
            this.type = type;
        }
        public void SetValue(string value)
        {
            this.value = value;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetBehaviorType()
        {
            return this.type;
        }
        public string GetValue()
        {
            return this.value;
        }
    }
}
