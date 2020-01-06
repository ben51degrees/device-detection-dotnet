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

internal class ResultsDeviceDetectionSwig : ResultsBaseSwig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ResultsDeviceDetectionSwig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DeviceDetectionPatternEngineModulePINVOKE.ResultsDeviceDetectionSwig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResultsDeviceDetectionSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DeviceDetectionPatternEngineModulePINVOKE.delete_ResultsDeviceDetectionSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual string getDeviceId() {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ResultsDeviceDetectionSwig_getDeviceId(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string getUserAgent(uint resultIndex) {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ResultsDeviceDetectionSwig_getUserAgent(swigCPtr, resultIndex);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getUserAgents() {
    int ret = DeviceDetectionPatternEngineModulePINVOKE.ResultsDeviceDetectionSwig_getUserAgents(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
