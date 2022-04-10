/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MTIP.Models;
using MTIP.Constants;

namespace MTIP.Models
{
    public class XmlItem
    {
        private string type;
        private string category;
        private string ea_id;
        private string cameo_id;
        private string parent;
        private string client;
        private string supplier;
        private string signal;
        private string composite_diagram;
        private string name;
        private string mapping_id;
        private string profile;
        private string profile_id;
        private string profile_name;
        private string typed_by;
        private string typed_by_name;
        private string classified_by;
        private string value_specification;
        private string hyperlink;
        private string hyperlink_type;
        private string ea_styles;
        private Dictionary<string, string> attributes;
        private Dictionary<string, string> constraints;
        private Dictionary<string, string> tagged_values;
        private Dictionary<string, Attribute> elementAttributes;
        private List<DiagramObjectItem> diagramObjects;
        private List<Behavior> behaviorObjects;
        private List<DiagramLinkItem> diagramLinks;

        public XmlItem()
        {
            this.type = "";
            this.category = "";
            this.ea_id = "";
            this.cameo_id = "";
            this.parent = "";
            this.client = "";
            this.supplier = "";
            this.signal = "";
            this.composite_diagram = "";
            this.name = "";
            this.mapping_id = "";
            this.profile = "";
            this.profile_id = "";
            this.profile_name = "";
            this.typed_by = "";
            this.typed_by_name = "";
            this.classified_by = "";
            this.value_specification = "";
            this.hyperlink = "";
            this.hyperlink_type = "";
            this.ea_styles = "";
            this.attributes = new Dictionary<string, string>();
            this.constraints = new Dictionary<string, string>();
            this.tagged_values = new Dictionary<string, string>();
            this.elementAttributes = new Dictionary<string, Attribute>();
            this.diagramObjects = new List<DiagramObjectItem>();
            this.behaviorObjects = new List<Behavior>();
            this.diagramLinks = new List<DiagramLinkItem>();
        }

        public void SetType(string type)
        {
            this.type = type;
            setCategory();
        }
        public void SetEAID(string ea_id)
        {
            this.ea_id = ea_id;
        }
        public void SetParent(string parent)
        {
            this.parent = parent;
        }
        public void AddAttribute(string key, string value)
        {
            if (key.Equals("name"))
            {
                value = value.Replace("(", "").Replace(")", "");
                SetName(value);
                this.attributes.Add(key, value);
            }
            else
            {
                this.attributes.Add(key, value);
            }
        }
        public void AddConstraint(string key, string type)
        {
            this.constraints.Add(key, type);
        }
        public void AddTaggedValue(string key, string type)
        {
            this.tagged_values.Add(key, type);
        }

        public void AddBehavior(Behavior behavior)
        {
            this.behaviorObjects.Add(behavior);
        }
        public void AddElementAttribute(string element, Dictionary<string, string> attributes)
        {
            Attribute attribute = new Attribute();
            attribute.SetName(element);
            foreach (KeyValuePair<string, string> elementAttribute in attributes)
            {
                attribute.AddAttribute(elementAttribute.Key, elementAttribute.Value);
            }
            this.elementAttributes.Add(element, attribute);
        }
        public void AddDiagramLinks(DiagramLinkItem diagramLinkObject)
        {
            this.diagramLinks.Add(diagramLinkObject);
        }
        public void SetClient(string client)
        {
            this.supplier = client;
        }

        public void SetSupplier(string supplier)
        {
            this.client = supplier;
        }
        public void SetCompositeDiagram(string composite_diagram)
        {
            this.composite_diagram = composite_diagram;
        }
        public void SetSignal(string signal)
        {
            this.signal = signal;
        }

        public void SetCameoID(string cameo_id)
        {
            this.cameo_id = cameo_id;
        }

        public void SetMappingID(string mapping_id)
        {
            this.mapping_id = mapping_id;
        }

        public void SetProfile(string profile)
        {
            this.profile = profile;
        }
        public void SetProfileId(string profile_id)
        {
            this.profile_id = profile_id;
        }
        public void SetProfileName(string profile_name)
        {
            this.profile_name = profile_name;
        }
        public void SetClassifiedBy(string classified_by)
        {
            this.classified_by = classified_by;
        }
        public void SetValueSpecification(string value_specification)
        {
            this.value_specification = value_specification;
        }
        public void SetEAStyles(string ea_styles)
        {
            this.ea_styles = ea_styles;
        }
        public void AddDiagramObjects(DiagramObjectItem diagramObject)
        {
            this.diagramObjects.Add(diagramObject);
        }
        public List<DiagramObjectItem> GetDiagramObjects(Dictionary<string, XmlItem> parsedXML)
        {
            //List<DiagramObjectItem> existingChildObjects = new List<DiagramObjectItem>();
            //foreach (DiagramObjectItem childObject in diagramObjects)
            //{
            //    if (parsedXML.ContainsKey(childObject.GetMappingId()))
            //    {
            //        existingChildObjects.Add(childObject);
            //    }
            //}
            return diagramObjects;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAttribute(string attribute, string value)
        {
            this.attributes[attribute] = value;
        }
        public void SetTypedBy(string typed_by)
        {
            this.typed_by = typed_by;
        }
        public void SetTypedByName(string typed_by_name)
        {
            this.typed_by_name = typed_by_name;
        }
        public void SetHyperlink(string hyperlink)
        {
            this.hyperlink = hyperlink;
        }
        public void SetHyperlinkType(string hyperlink_type)
        {
            this.hyperlink_type = hyperlink_type;
        }
        public string GetElementType()
        {
            return type;
        }
        public string GetCategory()
        {
            return category;
        }
        public string GetEAID()
        {
            return ea_id;
        }
        public string GetParent()
        {
            return parent;
        }
        public string GetAttribute(string key)
        {
            return attributes[key];
        }
        public string GetTaggedValue(string key)
        {
            return tagged_values[key];
        }

        public Dictionary<string, string> GetAttributes()
        {
            return attributes;
        }
        public Dictionary<string, string> GetTaggedValues()
        {
            return tagged_values;
        }
        public List<Behavior> GetBehaviors()
        {
            return behaviorObjects;
        }
        public Attribute GetElementAttribute(string key)
        {
            return elementAttributes[key];
        }
        public Dictionary<string, Attribute> GetElementAttributes()
        {
            return elementAttributes;
        }
        public string GetClient()
        {
            return client;
        }
        public string GetSupplier()
        {
            return supplier;
        }
        public string GetSignal()
        {
            return signal;
        }
        public string GetCompositeDiagram()
        {
            return composite_diagram;
        }
        public string GetCameoID()
        {
            return cameo_id;
        }
        public string GetMappingID()
        {
            return mapping_id;
        }
        public string GetProfile()
        {
            return profile;
        }
        public string GetProfileID()
        {
            return profile_id;
        }
        public string GetProfileName()
        {
            return profile_name;
        }
        public string GetClassifiedBy()
        {
            return classified_by;
        }
        public string GetValueSpecification()
        {
            return value_specification;
        }
        public string GetName()
        {
            return name;
        }
        public string GetTypedBy()
        {
            return typed_by;
        }
        public string GetHyperlink()
        {
            return hyperlink;
        }
        public string GetHyperlinkType()
        {
            return hyperlink_type;
        }
        public string GetTypedByName()
        {
            return typed_by_name;
        }
        public string GetEAStyles()
        {
            return ea_styles;
        }
        public List<DiagramLinkItem> GetDiagramLinks()
        {
            return diagramLinks;
        }
        //public DiagramLinkItem GetDiagramLinkById(string diagramLinkId)
        //{
        //    DiagramLinkItem diagramLinkToReturn = new DiagramLinkItem();
        //    foreach (DiagramLinkItem diagramLink in diagramLinks)
        //    {
        //        if (diagramLink.GetMappingId() == diagramLinkId) diagramLinkToReturn = diagramLink;
        //    }
        //    return diagramLinkToReturn;
        //}

        private void setCategory()
        {
            if (type == "Model")
            {
                category = SysmlConstants.MODEL;
            }
            if (type == "Profile")
            {
                category = SysmlConstants.PROFILE;
            }
            if (SysmlConstants.SYSMLELEMENTS.ToList().Contains(type))
            {
                category = SysmlConstants.ELEMENT;
            }
            if (SysmlConstants.SYSMLRELATIONSHIPS.ToList().Contains(type))
            {
                category = SysmlConstants.RELATIONSHIP;
            }
            if (SysmlConstants.SYSMLDIAGRAMS.ToList().Contains(type))
            {
                category = SysmlConstants.DIAGRAM;
            }
        }

        public Boolean IsCreated()
        {
            if (cameo_id.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
