//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.DeviceDetection.Pattern.Engine.OnPremise.Interop {

internal class EvidenceBaseSwig : MapStringStringSwig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal EvidenceBaseSwig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DeviceDetectionPatternEngineModulePINVOKE.EvidenceBaseSwig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EvidenceBaseSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DeviceDetectionPatternEngineModulePINVOKE.delete_EvidenceBaseSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public EvidenceBaseSwig() : this(DeviceDetectionPatternEngineModulePINVOKE.new_EvidenceBaseSwig(), true) {
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
