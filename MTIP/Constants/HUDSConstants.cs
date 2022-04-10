/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign node and attribute names when building HUDS XML
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class HUDSConstants
    {
        public string type;
        public string id;
        public string attributes;
        public string relationships;
        public string relationshipMetadata;
        public string dtype;
        public string str;
        public string dict;
        public string ea;
        public string name;
        public string status;
        public string key;
        public string data;
        public string typedBy;
        public string isComposite;
        public string list;
        public string element;
        public string value;
        public string intType;
        public HUDSConstants()
        {
            type = "type";
            id = "id";
            attributes = "attributes";
            relationships = "relationships";
            relationshipMetadata = "relationship_metadata";
            dtype = "_dtype";
            str = "str";
            dict = "dict";
            ea = "ea";
            name = "name";
            status = "status";
            key = "key";
            data = "data";
            typedBy = "typedBy";
            isComposite = "isComposite";
            list = "list";
            element = "element";
            value = "value";
            intType = "int";
        }
    }
}
