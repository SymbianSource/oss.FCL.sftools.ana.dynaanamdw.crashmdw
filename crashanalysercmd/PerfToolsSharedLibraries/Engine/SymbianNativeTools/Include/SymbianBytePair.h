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
#ifndef SYMBIANBYTEPAIR_H
#define SYMBIANBYTEPAIR_H

// User includes
#include "SymbianNativeToolsApi.h"

// Function definitions
extern "C" SYMBIANNATIVETOOL_API TInt SymbianBytePairUnpackRaw( TUint8* aDest, TInt aDestSize, TUint8* aSource, TInt aSourceSize );
extern "C" SYMBIANNATIVETOOL_API TInt SymbianBytePairUnpackImage( TUint8* aDest, TInt aDestSize, TUint8* aSource, TInt aSourceSize, TInt* aAmountOfInputRead );


#endif