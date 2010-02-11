/*
* Copyright (c) 2009 Nokia Corporation and/or its subsidiary(-ies). 
* All rights reserved.
* This component and the accompanying materials are made available
* under the terms of "Eclipse Public License v1.0"
* which accompanies this distribution, and is available
* at the URL "http://www.eclipse.org/legal/epl-v10.html".
*
* Initial Contributors:
* Nokia Corporation - initial contribution.
*
* Contributors:
* 
* Description:
*
*/
using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using SymbianTree;

namespace SymbianXmlInputLib.Elements
{
    public abstract class SXILElement : SymNodeAddAsChild, IEnumerable<SXILElement>
    {
        #region Constructors
        protected SXILElement()
        {
        }
        #endregion

        #region API
        #endregion

        #region Properties
        public abstract string Name
        {
            get;
            set;
        }
        #endregion

        #region Internal methods
        #endregion

        #region From IEnumerable<SXILElement>
        public IEnumerator<SXILElement> GetEnumerator()
        {
            foreach ( SymNode node in this.Children )
            {
                yield return node as SXILElement;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach ( SymNode node in this.Children )
            {
                yield return node as SXILElement;
            }
        }
        #endregion

        #region From System.Object
        public override string ToString()
        {
            return Name;
        }
        #endregion

        #region Data members
        #endregion
    }
}