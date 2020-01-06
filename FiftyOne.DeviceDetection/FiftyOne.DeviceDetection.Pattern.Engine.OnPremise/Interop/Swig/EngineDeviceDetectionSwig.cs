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

internal class EngineDeviceDetectionSwig : EngineBaseSwig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal EngineDeviceDetectionSwig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DeviceDetectionPatternEngineModulePINVOKE.EngineDeviceDetectionSwig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EngineDeviceDetectionSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DeviceDetectionPatternEngineModulePINVOKE.delete_EngineDeviceDetectionSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public static string defaultElementDataKey {
    set {
      DeviceDetectionPatternEngineModulePINVOKE.EngineDeviceDetectionSwig_defaultElementDataKey_set(value);
      if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = DeviceDetectionPatternEngineModulePINVOKE.EngineDeviceDetectionSwig_defaultElementDataKey_get();
      if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual ResultsDeviceDetectionSwig processDeviceDetection(EvidenceDeviceDetectionSwig evidence) {
    global::System.IntPtr cPtr = DeviceDetectionPatternEngineModulePINVOKE.EngineDeviceDetectionSwig_processDeviceDetection__SWIG_0(swigCPtr, EvidenceDeviceDetectionSwig.getCPtr(evidence));
    ResultsDeviceDetectionSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResultsDeviceDetectionSwig(cPtr, true);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ResultsDeviceDetectionSwig processDeviceDetection(string userAgent) {
    global::System.IntPtr cPtr = DeviceDetectionPatternEngineModulePINVOKE.EngineDeviceDetectionSwig_processDeviceDetection__SWIG_1(swigCPtr, userAgent);
    ResultsDeviceDetectionSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResultsDeviceDetectionSwig(cPtr, true);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
