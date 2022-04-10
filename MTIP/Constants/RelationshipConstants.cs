/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to create connectors/relationships between elements
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class RelationshipConstants
    {
        public string hasParent;
        public string id;
        public string element;
        public string relMetadata;
        public string relMetadataTop;
        public string relMetadataLeft;
        public string relMetadataBottom;
        public string relMetadataRight;
        public string relMetadataSeq;
        public string diagramConnector;
        public string messageNumber;
        public string typedBy;
        public string classifiedBy;
        public string valueSpecification;
        public string client;
        public string supplier;
        public string compositeDiagram;
        public string signature;
        public string profile;
        public string hyperlink;
        public string type;
        public string asynchSignal;
        public string signalGuid;
        public string asynchCall;
        public string synchCall;
        public string reply;
        public string metarelationship;
        public string metaclass;
        public string guard;
        public string effect;
        public string relationships;
        public string trigger;

        public RelationshipConstants()
        {
            this.hasParent = "hasParent";
            this.id = "id";
            this.element = "element";
            this.relMetadata = "relationship_metadata";
            this.relMetadataTop = "top";
            this.relMetadataLeft = "left";
            this.relMetadataBottom = "bottom";
            this.relMetadataRight = "right";
            this.relMetadataSeq = "sequence";
            this.diagramConnector = "diagramConnector";
            this.messageNumber = "messageNumber";
            this.typedBy = "typedBy";
            this.classifiedBy = "classifiedBy";
            this.valueSpecification = "valueSpecification";
            this.client = "client";
            this.supplier = "supplier";
            this.compositeDiagram = "compositeDiagram";
            this.signature = "signature";
            this.profile = "profile";
            this.hyperlink = "hyperlink";
            this.type = "type";
            this.asynchSignal = "asynchSignal";
            this.signalGuid = "signal_guid";
            this.asynchCall = "asynchCall";
            this.synchCall = "synchCall";
            this.reply = "reply";
            this.metarelationship = "metarelationship";
            this.metaclass = "metaclass";
            this.guard = "guard";
            this.effect = "effect";
            this.relationships = "relationships";
            this.trigger = "trigger";
        }
    }
}
