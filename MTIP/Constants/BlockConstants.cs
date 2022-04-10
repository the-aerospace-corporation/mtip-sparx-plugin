/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Block types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class BlockConstants
    {
        public string block;
        public string constraintBlock;
        public string association;
        public string enumeration;
        public string external;
        public string port;
        public string proxyPort;
        public string fullPort;
        public string flowPort;
        public string interfaceType;
        public string interfaceBlock;
        public string operation;
        public string dataType;
        public string property;
        public string signal;
        public string unit;
        public string quantityKind;
        public string valueType;
        public BlockConstants()
        {
            block = "Block";
            constraintBlock = "ConstraintBlock";
            association = "Association";
            enumeration = "Enumeration";
            external = "External";
            port = "Port";
            proxyPort = "ProxyPort";
            fullPort = "FullPort";
            flowPort = "FlowPort";
            interfaceType = "Interface";
            interfaceBlock = "InterfaceBlock";
            operation = "Operation";
            dataType = "DataType";
            property = "property";
            signal = "Signal";
            unit = "Unit";
            quantityKind = "QuantityKind";
            valueType = "ValueType";
        }
    }
}
