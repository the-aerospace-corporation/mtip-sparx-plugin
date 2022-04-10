/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node diagramLinkItem metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Models
{
    public class DiagramLinkItem
    {
        private string mappingId;
        private string hidden;
        private string sequence;

        public DiagramLinkItem()
        {
              this.mappingId = "";
              this.hidden = "";
              this.sequence = "";
    }
        public void SetMappingId(string mappingId)
        {
            this.mappingId = mappingId;
        }
        public void SetHidden(string hidden)
        {
            this.hidden = hidden;
        }
        public void SetSequence(string sequence)
        {
            this.sequence = sequence;
        }
        public string GetMappingId()
        {
            return this.mappingId;
        }
        public string GetHidden()
        {
            return this.hidden;
        }
        public string GetSequence()
        {
            return this.sequence;
        }
    }
}
