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

internal class DoubleValueSwig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DoubleValueSwig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DoubleValueSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DoubleValueSwig() {
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
          DeviceDetectionHashEngineModulePINVOKE.delete_DoubleValueSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public DoubleValueSwig() : this(DeviceDetectionHashEngineModulePINVOKE.new_DoubleValueSwig(), true) {
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasValue() {
    bool ret = DeviceDetectionHashEngineModulePINVOKE.DoubleValueSwig_hasValue(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getNoValueMessage() {
    string ret = DeviceDetectionHashEngineModulePINVOKE.DoubleValueSwig_getNoValueMessage(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double getValue() {
    double ret = DeviceDetectionHashEngineModulePINVOKE.DoubleValueSwig_getValue(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
