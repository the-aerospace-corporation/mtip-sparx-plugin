/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Internal Block types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class InternalBlockConstants
    {
        public string boundReference;
        public string boundary;
        public string property;
        public string flowProperty;
        public string referenceProperty;
        public string constraintProperty;
        public string participantProperty;

        public InternalBlockConstants()
        {
            boundReference = "BoundReference";
            boundary = "Boundary";
            property = "Property";
            flowProperty = "FlowProperty";
            referenceProperty = "ReferenceProperty";
            constraintProperty = "ConstraintProperty";
            participantProperty = "ParticipantProperty";
        }
    }
}
