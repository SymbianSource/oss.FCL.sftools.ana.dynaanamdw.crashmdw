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
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using SymbianUtils;
using SymbianUtils.Settings;
using SymbianUtils.FileSystem.Utilities;
using SymbianUtilsUi.Dialogs;
using CrashAnalyser.UI;
using CrashAnalyserEngine.Engine;

namespace CrashAnalyser
{
	public static class EntryPoint
	{
		#region Application entry point
		[STAThread]
		static void Main() 
		{
            // Create UI manager which will act as application context
            try
            {
                FSUtilities.ClearTempPath();
                CAGraphicalUIManager uiManager = new CAGraphicalUIManager();
                uiManager.Run();
            }
            catch ( Exception exception )
            {
                SymExceptionDialog dialog = new SymExceptionDialog();
                dialog.Exception = exception;
                dialog.ShowDialog();
            }
		}
		#endregion
    }
}
