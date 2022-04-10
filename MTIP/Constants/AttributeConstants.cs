/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to store property metadata for elements, 
 *              diagrams and connectors
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class AttributeConstants
    {
        public string id;
        public string attribute;
        public string attributes;
        public string relationships;
        public string type;
        public string initialValue;
        public string visibility;
        public string stereotype;
        public string alias;
        public string name;
        public string value;
        public string stereotypeName;
        public string documentation;
        public string profileId;
        public string profileName;
        public string displayAs;
        public string constraint;
        public string taggedValue;
        public string behavior;
        public string receiveEvent;
        public string sendEvent;
        public string text;
        public string messageSort;
        public string submachine;
        public string interactionOperatorKind;
        public string extensionPoint;
        public string multiplicity;
        public string defaultValue;
        public string isComposite;
        public string body;

        public AttributeConstants()
        {
            this.id = "id";
            this.attribute = "attribute";
            this.attributes = "attributes";
            this.relationships = "relationships";
            this.type = "type";
            this.initialValue = "initialValue";
            this.visibility = "visibility";
            this.stereotype = "stereotype";
            this.alias = "alias";
            this.name = "name";
            this.value = "value";
            this.stereotypeName = "stereotypeName";
            this.documentation = "documentation";
            this.profileId = "profileId";
            this.profileName = "profileName";
            this.displayAs = "displayAs";
            this.constraint = "constraint";
            this.taggedValue = "taggedValue";
            this.behavior = "behavior";
            this.receiveEvent = "receiveEvent";
            this.sendEvent = "sendEvent";
            this.text = "text";
            this.messageSort = "messageSort";
            this.submachine = "submachine";
            this.interactionOperatorKind = "interactionOperatorKind";
            this.extensionPoint = "extensionPoint";
            this.multiplicity = "multiplicity";
            this.defaultValue = "defaultValue";
            this.isComposite = "isComposite";
            this.body = "body";
        }

    }
}
