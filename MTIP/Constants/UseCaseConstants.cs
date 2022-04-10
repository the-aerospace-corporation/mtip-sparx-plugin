/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants for types used to assign Use Case element types
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class UseCaseConstants
    {
        public string actor;
        public string useCase;
        public UseCaseConstants()
        {
            actor = "Actor";
            useCase = "UseCase";
        }
    }
}
