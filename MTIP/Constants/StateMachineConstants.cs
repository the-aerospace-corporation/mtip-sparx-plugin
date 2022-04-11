/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign State Machine element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class StateMachineConstants
    {
        public string entryPoint;
        public string exitPoint;
        public string synchronization;
        public string region;
        public string state;
        public string stateMachine;
        public string stateNode;
        public string trigger;
        public string deepHistory;
        public string shallowHistory;
        public StateMachineConstants()
        {
            entryPoint = "EntryPoint";
            exitPoint = "ExitPoint";
            synchronization = "Synchronization";
            region = "Region";
            state = "State";
            stateMachine = "StateMachine";
            stateNode = "StateNode";
            trigger = "Trigger";
        }
    }
}
