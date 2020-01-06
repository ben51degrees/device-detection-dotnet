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

internal class VectorStringSwig : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorStringSwig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorStringSwig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorStringSwig() {
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
          DeviceDetectionPatternEngineModulePINVOKE.delete_VectorStringSwig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorStringSwig(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public VectorStringSwig(global::System.Collections.Generic.IEnumerable<string> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public string this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(string[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, string[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public string[] ToArray() {
    string[] array = new string[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator() {
    return new VectorStringSwigEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VectorStringSwigEnumerator(this);
  }

  public VectorStringSwigEnumerator GetEnumerator() {
    return new VectorStringSwigEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VectorStringSwigEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<string>
  {
    private VectorStringSwig collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VectorStringSwigEnumerator(VectorStringSwig collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public string Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (string)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Clear(swigCPtr);
  }

  public void Add(string x) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Add(swigCPtr, x);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_reserve(swigCPtr, n);
  }

  public VectorStringSwig() : this(DeviceDetectionPatternEngineModulePINVOKE.new_VectorStringSwig__SWIG_0(), true) {
  }

  public VectorStringSwig(VectorStringSwig other) : this(DeviceDetectionPatternEngineModulePINVOKE.new_VectorStringSwig__SWIG_1(VectorStringSwig.getCPtr(other)), true) {
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorStringSwig(int capacity) : this(DeviceDetectionPatternEngineModulePINVOKE.new_VectorStringSwig__SWIG_2(capacity), true) {
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  private string getitemcopy(int index) {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_getitemcopy(swigCPtr, index);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string getitem(int index) {
    string ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_getitem(swigCPtr, index);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, string val) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_setitem(swigCPtr, index, val);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VectorStringSwig values) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_AddRange(swigCPtr, VectorStringSwig.getCPtr(values));
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorStringSwig GetRange(int index, int count) {
    global::System.IntPtr cPtr = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_GetRange(swigCPtr, index, count);
    VectorStringSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorStringSwig(cPtr, true);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, string x) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Insert(swigCPtr, index, x);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VectorStringSwig values) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_InsertRange(swigCPtr, index, VectorStringSwig.getCPtr(values));
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_RemoveAt(swigCPtr, index);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_RemoveRange(swigCPtr, index, count);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public static VectorStringSwig Repeat(string value, int count) {
    global::System.IntPtr cPtr = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Repeat(value, count);
    VectorStringSwig ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorStringSwig(cPtr, true);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Reverse__SWIG_1(swigCPtr, index, count);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VectorStringSwig values) {
    DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_SetRange(swigCPtr, index, VectorStringSwig.getCPtr(values));
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(string value) {
    bool ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Contains(swigCPtr, value);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(string value) {
    int ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_IndexOf(swigCPtr, value);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(string value) {
    int ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_LastIndexOf(swigCPtr, value);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(string value) {
    bool ret = DeviceDetectionPatternEngineModulePINVOKE.VectorStringSwig_Remove(swigCPtr, value);
    if (DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Pending) throw DeviceDetectionPatternEngineModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
