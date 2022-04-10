/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for values that do not fall within any diagram element type
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class ProfileConstants
    {
        public string classType;
        public string part;
        public string constraint;
        public string objectType;
        public string exceptionHandler;
        public string package;
        public string text;
        public string note;
        public string objectiveFunction;

        public ProfileConstants(){
            classType = "Class";
            part = "Part";
            constraint = "Constraint";
            objectType = "Object";
            exceptionHandler = "ExceptionHandler";
            package = "Package";
            text = "Text";
            note = "Note";
            objectiveFunction = "ObjectiveFunction";
        }

    }
}
