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

internal class ValueMetaDataSwig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ValueMetaDataSwig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ValueMetaDataSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ValueMetaDataSwig() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DeviceDetectionPatternEngineModulePINVOKE.delete_ValueMetaDataSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string getName() {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ValueMetaDataSwig_getName(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDescription() {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ValueMetaDataSwig_getDescription(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getUrl() {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ValueMetaDataSwig_getUrl(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
