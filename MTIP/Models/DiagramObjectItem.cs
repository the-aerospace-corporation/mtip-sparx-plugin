/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node diagram object metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Models
{
    public class DiagramObjectItem
    {
        private string mappingId;
        private string topCoor;
        private string bottomCoor;
        private string leftCoor;
        private string rightCoor;
        private string sequenceCoor;

        public DiagramObjectItem()
        {
            this.mappingId = "";
            this.topCoor = "";
            this.bottomCoor = "";
            this.leftCoor = "";
            this.rightCoor = "";
            this.sequenceCoor = "";
    }
        public void SetMappingId(string mappingId)
        {
            this.mappingId = mappingId;
        }
        public void SetTopCoor(string topCoor)
        {
            this.topCoor = topCoor;
        }
        public void SetBottomCoor(string bottomCoor)
        {
            this.bottomCoor = bottomCoor;
        }
        public void SetLeftCoor(string leftCoor)
        {
            this.leftCoor = leftCoor;
        }
        public void SetRightCoor(string rightCoor)
        {
            this.rightCoor = rightCoor;
        }
        public void SetSequenceCoor(string sequenceCoor)
        {
            this.sequenceCoor = sequenceCoor;
        }
        public string GetMappingId()
        {
            return this.mappingId;
        }
        public string GetTopCoor()
        {
            return this.topCoor;
        }
        public string GetBottomCoor()
        {
            return this.bottomCoor;
        }
        public string GetLeftCoor()
        {
            return this.leftCoor;
        }
        public string GetRightCoor()
        {
            return this.rightCoor;
        }
        public string GetSequenceCoor()
        {
            return this.sequenceCoor;
        }
    }
}
