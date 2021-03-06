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

namespace SymbolLib.Generics
{
	public interface IGenericSymbolCollectionLookupInterface
	{
		#region Query symbol entry & collection by address
		GenericSymbol EntryByAddress( long aAddress, ref GenericSymbolCollection aCollection );
		#endregion

		#region Query collection by address
		GenericSymbolCollection CollectionByAddress( long aAddress );
		#endregion
	}
}
