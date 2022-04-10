/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Model element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class ModelConstants
    {
        public string model;
        public string stereotype;
        public string profile;
        public string documentation;
        public string text;
        public ModelConstants()
        {
            this.model = "Model";
            this.stereotype = "stereotype";
            this.profile = "profile";
            this.documentation = "documentation";
            this.text = "text";
        }
    }
}
