/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Object used to store data node glossary term metadata from HUDS XML file.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Models
{
    public class GlossaryTerm
    {
        private string name;
        private string termType;
        private string meaning;
        public GlossaryTerm()
        {
        }
        public GlossaryTerm(string name, string type, string meaning)
        {
            GlossaryTerm term = new GlossaryTerm();

            term.name = name;
            term.termType = termType;
            term.meaning = meaning;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetTermType(string termType)
        {
            this.termType = termType;
        }
        public void SetMeaning(string meaning)
        {
            this.meaning = meaning;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetTermType()
        {
            return this.termType;
        }
        public string GetMeaning()
        {
            return this.meaning;
        }
    }

}
