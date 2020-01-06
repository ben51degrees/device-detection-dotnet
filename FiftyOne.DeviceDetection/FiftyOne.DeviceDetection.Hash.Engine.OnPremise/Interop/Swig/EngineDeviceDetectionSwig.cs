/* ********************************************************************
 * Copyright (C) 2019  51Degrees Mobile Experts Limited.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * ******************************************************************** */

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.DeviceDetection.Hash.Engine.OnPremise.Interop {

internal class EngineDeviceDetectionSwig : EngineBaseSwig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal EngineDeviceDetectionSwig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DeviceDetectionHashEngineModulePINVOKE.EngineDeviceDetectionSwig_SWIGUpcast(cPtr), cMemoryOwn) {
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
          DeviceDetectionHashEngineModulePINVOKE.delete_EngineDeviceDetectionSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public static string defaultElementDataKey {
    set {
      DeviceDetectionHashEngineModulePINVOKE.EngineDeviceDetectionSwig_defaultElementDataKey_set(value);
      if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = DeviceDetectionHashEngineModulePINVOKE.EngineDeviceDetectionSwig_defaultElementDataKey_get();
      if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual ResultsDeviceDetectionSwig processDeviceDetection(EvidenceDeviceDetectionSwig evidence) {
    global::System.IntPtr cPtr = DeviceDetectionHashEngineModulePINVOKE.EngineDeviceDetectionSwig_processDeviceDetection__SWIG_0(swigCPtr, EvidenceDeviceDetectionSwig.getCPtr(evidence));
    ResultsDeviceDetectionSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResultsDeviceDetectionSwig(cPtr, true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ResultsDeviceDetectionSwig processDeviceDetection(string userAgent) {
    global::System.IntPtr cPtr = DeviceDetectionHashEngineModulePINVOKE.EngineDeviceDetectionSwig_processDeviceDetection__SWIG_1(swigCPtr, userAgent);
    ResultsDeviceDetectionSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResultsDeviceDetectionSwig(cPtr, true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
