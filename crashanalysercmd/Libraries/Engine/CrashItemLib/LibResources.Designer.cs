﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrashItemLib {
    using System;
    
    
    // <summary>
    //   A strongly-typed resource class, for looking up localized strings, etc.
    // </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LibResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LibResources() {
        }
        
        // <summary>
        //   Returns the cached ResourceManager instance used by this class.
        // </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrashItemLib.LibResources", typeof(LibResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        // <summary>
        //   Overrides the current thread's CurrentUICulture property for all
        //   resource lookups using this strongly typed resource class.
        // </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to The code segment: &apos;{0}&apos;, for process: &apos;{1}&apos; conflicts with the symbolic information..
        // </summary>
        internal static string CIPDCodeSegAvailability_CodeSegMisMatch_Description_L1 {
            get {
                return ResourceManager.GetString("CIPDCodeSegAvailability_CodeSegMisMatch_Description_L1", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Crash data indicates that the code segment base address is 0x{0:x8}, however, symbolic information suggests it should be: 0x{1:x8}.
        // </summary>
        internal static string CIPDCodeSegAvailability_CodeSegMisMatch_Description_L2 {
            get {
                return ResourceManager.GetString("CIPDCodeSegAvailability_CodeSegMisMatch_Description_L2", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Code Segment Mismatch.
        // </summary>
        internal static string CIPDCodeSegAvailability_CodeSegMisMatch_Title {
            get {
                return ResourceManager.GetString("CIPDCodeSegAvailability_CodeSegMisMatch_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to The code segment: &apos;{0}&apos;, for process: &apos;{1}&apos; does not have any associated symbols..
        // </summary>
        internal static string CIPDCodeSegAvailability_NoSymbols_Description {
            get {
                return ResourceManager.GetString("CIPDCodeSegAvailability_NoSymbols_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Symbols Unavailable.
        // </summary>
        internal static string CIPDCodeSegAvailability_NoSymbols_Title {
            get {
                return ResourceManager.GetString("CIPDCodeSegAvailability_NoSymbols_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the registers do not contain a value for the link register (R14)..
        // </summary>
        internal static string CIPDRegAvailability_MissingLR_Description {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingLR_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Link Register (R14) Not Available.
        // </summary>
        internal static string CIPDRegAvailability_MissingLR_Title {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingLR_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the registers do not contain a value for the program counter (R15)..
        // </summary>
        internal static string CIPDRegAvailability_MissingPC_Description {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingPC_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Program Counter (R15) Not Available.
        // </summary>
        internal static string CIPDRegAvailability_MissingPC_Title {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingPC_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the registers do not contain a value for the current stack pointer (R13)..
        // </summary>
        internal static string CIPDRegAvailability_MissingSP_Description {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingSP_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Pointer (R13) Not Available.
        // </summary>
        internal static string CIPDRegAvailability_MissingSP_Title {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_MissingSP_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the stack has no associated registers which reduces the accuracy of stack decoding..
        // </summary>
        internal static string CIPDRegAvailability_NoRegsForStack_Description {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_NoRegsForStack_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Registers Missing.
        // </summary>
        internal static string CIPDRegAvailability_NoRegsForStack_Title {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_NoRegsForStack_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} R00 was null and the thread raised an exception. This suggests a possible de-reference of a NULL &apos;this&apos; pointer..
        // </summary>
        internal static string CIPDRegAvailability_NullThisPointer_Description {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_NullThisPointer_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Possible De-reference of NULL &apos;this&apos; Pointer?.
        // </summary>
        internal static string CIPDRegAvailability_NullThisPointer_Title {
            get {
                return ResourceManager.GetString("CIPDRegAvailability_NullThisPointer_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the stack pointer is beyond the start of the stack range, which will result in an exception..
        // </summary>
        internal static string CIPDStackBoundaryValidator_StackOverflow_Description {
            get {
                return ResourceManager.GetString("CIPDStackBoundaryValidator_StackOverflow_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Overflow.
        // </summary>
        internal static string CIPDStackBoundaryValidator_StackOverflow_Title {
            get {
                return ResourceManager.GetString("CIPDStackBoundaryValidator_StackOverflow_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the stack pointer is outside of the stack address range..
        // </summary>
        internal static string CIPDStackBoundaryValidator_StackUnderflow_Description {
            get {
                return ResourceManager.GetString("CIPDStackBoundaryValidator_StackUnderflow_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Underflow.
        // </summary>
        internal static string CIPDStackBoundaryValidator_StackUnderflow_Title {
            get {
                return ResourceManager.GetString("CIPDStackBoundaryValidator_StackUnderflow_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} no registers are available, which may result in incomplete analysis..
        // </summary>
        internal static string CIPDStackRegisterAvailability_MissingRegisters_Description {
            get {
                return ResourceManager.GetString("CIPDStackRegisterAvailability_MissingRegisters_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Registers Missing.
        // </summary>
        internal static string CIPDStackRegisterAvailability_MissingRegisters_Title {
            get {
                return ResourceManager.GetString("CIPDStackRegisterAvailability_MissingRegisters_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} stack data has been supplied but the stack pointer value is missing..
        // </summary>
        internal static string CIPDStackRegisterAvailability_MissingSP_Description {
            get {
                return ResourceManager.GetString("CIPDStackRegisterAvailability_MissingSP_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Pointer (R13) Not Available.
        // </summary>
        internal static string CIPDStackRegisterAvailability_MissingSP_Title {
            get {
                return ResourceManager.GetString("CIPDStackRegisterAvailability_MissingSP_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} stack data is not available..
        // </summary>
        internal static string CIPDThreadValidity_NoStack_Description {
            get {
                return ResourceManager.GetString("CIPDThreadValidity_NoStack_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Data Unavailable.
        // </summary>
        internal static string CIPDThreadValidity_NoStack_Title {
            get {
                return ResourceManager.GetString("CIPDThreadValidity_NoStack_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to In relation to the {0} mode stack,.
        // </summary>
        internal static string CIProblemDetector_Msg_Stack {
            get {
                return ResourceManager.GetString("CIProblemDetector_Msg_Stack", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to In relation to the thread &apos;{0}&apos;,.
        // </summary>
        internal static string CIProblemDetector_Msg_Thread {
            get {
                return ResourceManager.GetString("CIProblemDetector_Msg_Thread", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to The stack base address appears to be invalid..
        // </summary>
        internal static string CIStackBuilder_AddressInfoException_BaseAddressBeforeTopAddress {
            get {
                return ResourceManager.GetString("CIStackBuilder_AddressInfoException_BaseAddressBeforeTopAddress", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Unable to reconstruct call stack as no value was supplied for the current stack pointer (R13)..
        // </summary>
        internal static string CIStackBuilder_AddressInfoException_PointerMissing {
            get {
                return ResourceManager.GetString("CIStackBuilder_AddressInfoException_PointerMissing", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to The current stack pointer (R13) is outside of the stack address boundary..
        // </summary>
        internal static string CIStackBuilder_AddressInfoException_PointerOutOfBounds {
            get {
                return ResourceManager.GetString("CIStackBuilder_AddressInfoException_PointerOutOfBounds", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to The stack top/limiting address appears to be invalid..
        // </summary>
        internal static string CIStackBuilder_AddressInfoException_TopAddressAfterBaseAddress {
            get {
                return ResourceManager.GetString("CIStackBuilder_AddressInfoException_TopAddressAfterBaseAddress", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Reconstruction Error.
        // </summary>
        internal static string CIStackBuilder_Error_Title {
            get {
                return ResourceManager.GetString("CIStackBuilder_Error_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Reconstruction Warning.
        // </summary>
        internal static string CIStackBuilder_Warning_Title {
            get {
                return ResourceManager.GetString("CIStackBuilder_Warning_Title", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to {0} the stack pointer is outside of the supplied stack data. This may mean that part of the reconstructed call stack is omitted..
        // </summary>
        internal static string CPIDStackDataValidator_Description {
            get {
                return ResourceManager.GetString("CPIDStackDataValidator_Description", resourceCulture);
            }
        }
        
        // <summary>
        //   Looks up a localized string similar to Stack Data Incomplete.
        // </summary>
        internal static string CPIDStackDataValidator_Title {
            get {
                return ResourceManager.GetString("CPIDStackDataValidator_Title", resourceCulture);
            }
        }
    }
}
