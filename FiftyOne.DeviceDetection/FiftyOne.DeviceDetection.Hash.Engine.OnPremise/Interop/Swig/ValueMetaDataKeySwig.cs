//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.DeviceDetection.Hash.Engine.OnPremise.Interop {

internal class ValueMetaDataKeySwig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ValueMetaDataKeySwig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ValueMetaDataKeySwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ValueMetaDataKeySwig() {
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
          DeviceDetectionHashEngineModulePINVOKE.delete_ValueMetaDataKeySwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ValueMetaDataKeySwig(string propertyName, string valueName) : this(DeviceDetectionHashEngineModulePINVOKE.new_ValueMetaDataKeySwig(propertyName, valueName), true) {
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getPropertyName() {
    string ret = DeviceDetectionHashEngineModulePINVOKE.ValueMetaDataKeySwig_getPropertyName(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValueName() {
    string ret = DeviceDetectionHashEngineModulePINVOKE.ValueMetaDataKeySwig_getValueName(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
