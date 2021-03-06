/*
* Copyright (c) 2004-2008 Nokia Corporation and/or its subsidiary(-ies).
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
using SymbianTree;
using SymBuildParsingLib.Tree;
using SymBuildParsingLib.Common.Objects;

namespace SymBuildParsingLib.Parser.PreProcessor.Nodes
{
	public class SymNodePreProcessorDefine : SymNodeAddAsChild
	{
		#region Constructors & destructor
		public SymNodePreProcessorDefine()
		{
		}
		#endregion

		#region API
		public SymDefineDefinition DefineDefinition
		{
			get
			{
				SymDefineDefinition ret = null;
				//
				if	( Data == null )
				{
					ret = new SymDefineDefinition();
					Data = ret;
				}
				else
				{
					ret = (SymDefineDefinition) Data;
				}
				//
				return ret;
			}
			set { Data = value; }
		}
		#endregion
	}
}
