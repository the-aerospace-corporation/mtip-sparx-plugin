/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Requirement element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class RequirementConstants
    {
        public string requirement;
        public string designConstraint;
        public string extendedRequirement;
        public string functionalRequirement;
        public string interfaceRequirement;
        public string performanceRequirement;
        public string physicalRequirement;
        public RequirementConstants()
        {
            requirement = "Requirement";
            designConstraint = "DesignConstraint";
            extendedRequirement = "ExtendedRequirement";
            functionalRequirement = "FunctionalRequirement";
            interfaceRequirement = "InterfaceRequirement";
            performanceRequirement = "PerformanceRequirement";
            physicalRequirement = "PhysicalRequirement";
        }
    }
}
