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

internal class ConfigHashSwig : ConfigDeviceDetectionSwig {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ConfigHashSwig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConfigHashSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DeviceDetectionHashEngineModulePINVOKE.delete_ConfigHashSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ConfigHashSwig() : this(DeviceDetectionHashEngineModulePINVOKE.new_ConfigHashSwig(), true) {
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setHighPerformance() {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setHighPerformance(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBalanced() {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setBalanced(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBalancedTemp() {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setBalancedTemp(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLowMemory() {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setLowMemory(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaxPerformance() {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setMaxPerformance(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDrift(int drift) {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setDrift(swigCPtr, drift);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDifference(int difference) {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setDifference(swigCPtr, difference);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setConcurrency(ushort concurrency) {
    DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_setConcurrency(swigCPtr, concurrency);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public CollectionConfigSwig getStrings() {
    CollectionConfigSwig ret = new CollectionConfigSwig(DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getStrings(swigCPtr), true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CollectionConfigSwig getProfiles() {
    CollectionConfigSwig ret = new CollectionConfigSwig(DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getProfiles(swigCPtr), true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CollectionConfigSwig getDevices() {
    CollectionConfigSwig ret = new CollectionConfigSwig(DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getDevices(swigCPtr), true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CollectionConfigSwig getNodes() {
    CollectionConfigSwig ret = new CollectionConfigSwig(DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getNodes(swigCPtr), true);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getDrift() {
    int ret = DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getDrift(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getDifference() {
    int ret = DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getDifference(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ushort getConcurrency() {
    ushort ret = DeviceDetectionHashEngineModulePINVOKE.ConfigHashSwig_getConcurrency(swigCPtr);
    if (DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionHashEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
