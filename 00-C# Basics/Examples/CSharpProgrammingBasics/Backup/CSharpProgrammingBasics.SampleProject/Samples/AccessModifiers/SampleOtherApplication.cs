/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 9:04:10 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 9:04:10 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.AccessModifiers;

namespace CSharpProgrammingBasics.SampleProject.Samples.AccessModifiers
{
    /// <summary>
    /// <write description here>
    /// </summary>
    public class SampleOtherApplication
    {
        private void SampleMethodThatUsesAccesModifiersSamples()
        {
            //the public property can be accessed here only
            SampleAccessModifiersBaseClass _accessModifiersInstance = new SampleAccessModifiersBaseClass();
            _accessModifiersInstance.SamplePublicProperty = 124;
        }
    }
}