/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign MetaTypes
 * 
 * Note: Meta
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class MetatypeConstants
    {
        public string pseudostate;
        public string acceptEventAction;
        public string callBehaviorAction;
        public string opaqueAction;
        public string sendSignalAction;
        public string callOperationAction;
        public string createObjectAction;
        public string destroyObjectAction;
        public MetatypeConstants()
        {
            pseudostate = "Pseudostate";
            acceptEventAction = "AcceptEventAction";
            callBehaviorAction = "CallBehaviorAction";
            opaqueAction = "OpaqueAction";
            sendSignalAction = "SendSignalAction";
            callOperationAction = "CallOperationAction";
            createObjectAction = "CreateObjectAction";
            destroyObjectAction = "DestroyObjectAction";
        }
    }
}
