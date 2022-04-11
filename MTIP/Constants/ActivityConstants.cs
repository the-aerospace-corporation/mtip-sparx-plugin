/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Activity element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class ActivityConstants
    {
        public string acceptEventAction;
        public string activity;
        public string action;
        public string actionPin;
        public string stateNode;
        public string activityParameter;
        public string activityPartion;
        public string callBehaviorAction;
        public string callOperationAction;
        public string centralBufferNode;
        public string createObjectAction;
        public string property;
        public string destroyObjectAction;
        public string conditionalNode;
        public string decision;
        public string eventType;
        public string interruptibleActivityRegion;
        public string mergeNode;
        public string objectNode;
        public string forkNode;
        public string synchronization;
        public string sendSignalAction;
        public string change;
        public string informationItem;


        public ActivityConstants(){
            activity = "Activity";
            stateNode = "StateNode";
            acceptEventAction = "AcceptEventAction";
            activityParameter = "ActivityParameter";
            activityPartion = "ActivityPartition";
            action = "Action";
            actionPin = "ActionPin";
            callBehaviorAction = "CallBehaviorAction";
            callOperationAction = "CallOperationAction";
            centralBufferNode = "CentralBufferNode";
            createObjectAction = "CreateObjectAction";
            destroyObjectAction = "DestroyObjectAction";
            property = "Property";
            conditionalNode = "ConditionalNode";
            decision = "Decision";
            eventType = "Event";
            interruptibleActivityRegion = "InterruptibleActivityRegion";
            mergeNode = "MergeNode";
            objectNode = "ObjectNode";
            forkNode = "ForkNode";
            synchronization = "Synchronization";
            sendSignalAction = "SendSignalAction";
            change = "Change";
            informationItem = "InformationItem";
        }
    }
}
