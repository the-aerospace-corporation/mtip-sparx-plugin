/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Diagram types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class DiagramConstants
    {
        public string component;
        public string activity;
        public string logical;
        public string classType;
        public string compositeStructure;
        public string package;
        public string custom;
        public string sequence;
        public string statechart;
        public string useCase;
        public DiagramConstants()
        {
            component = "Component";
            activity = "Activity";
            logical = "Logical";
            classType = "Class";
            compositeStructure = "CompositeStructure";
            package = "Package";
            custom = "Custom";
            sequence = "Sequence";
            statechart = "Statechart";
            useCase = "Use Case";
        }
    }
}
