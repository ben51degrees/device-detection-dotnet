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

internal class ComponentMetaDataSwig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ComponentMetaDataSwig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ComponentMetaDataSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ComponentMetaDataSwig() {
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
          DeviceDetectionPatternEngineModulePINVOKE.delete_ComponentMetaDataSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int getComponentIdAsInt() {
    int ret = DeviceDetectionPatternEngineModulePINVOKE.ComponentMetaDataSwig_getComponentIdAsInt(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_byte getComponentId() {
    SWIGTYPE_p_byte ret = new SWIGTYPE_p_byte(DeviceDetectionPatternEngineModulePINVOKE.ComponentMetaDataSwig_getComponentId(swigCPtr), true);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.ComponentMetaDataSwig_getName(swigCPtr);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
