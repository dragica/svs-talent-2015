/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 9:08:42 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 9:08:42 AM
    
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
    internal class SampleOtherApplicationInherited:SampleAccessModifiersBaseClass
    {
        private void SampleMethodInOtherApplicationInheritedClass()
        {
            //use the protected internal proeprty here
            base.SampleProtectedInternalProperty = new object[] { 4, 5, 6 };
            //normally use public and protected properties
            base.SamplePublicProperty = 1;
            base.SampleProtectedProperty = 1.5f;
        }
    }
}