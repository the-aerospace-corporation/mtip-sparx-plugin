/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Sequence element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class SequenceConstants
    {
        public string collaboration;
        public string interactionFragment;
        public string sequence;
        public string interaction;
        public SequenceConstants()
        {
            collaboration = "Collaboration";
            interactionFragment = "InteractionFragment";
            sequence = "Sequence";
            interaction = "Interaction";
        }
    }
}
