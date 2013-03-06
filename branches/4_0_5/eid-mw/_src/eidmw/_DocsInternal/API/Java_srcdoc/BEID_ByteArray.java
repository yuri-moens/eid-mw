/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package be.belgium.eid;

/******************************************************************************//**
  * This class is used to receive/pass byte arrays
  *********************************************************************************/
public class BEID_ByteArray extends BEID_Object {
  private long swigCPtr;

  protected BEID_ByteArray(long cPtr, boolean cMemoryOwn) {
    super(beidlibJava_WrapperJNI.SWIGBEID_ByteArrayUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BEID_ByteArray obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      beidlibJava_WrapperJNI.delete_BEID_ByteArray(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

	/** Default constructor */
  public BEID_ByteArray() {
    this(beidlibJava_WrapperJNI.new_BEID_ByteArray__SWIG_0(), true);
  }

	/** Copy constructor */
  public BEID_ByteArray(BEID_ByteArray bytearray) {
    this(beidlibJava_WrapperJNI.new_BEID_ByteArray__SWIG_1(BEID_ByteArray.getCPtr(bytearray), bytearray), true);
  }

	 /**
	  * Constructor - initialize a byte array with a byte[]
	  *
	  * @param pucData the byte[] input
	  * @param ulSize the size of the input array
	  */
  public BEID_ByteArray(byte[] pucData, long ulSize) {
    this(beidlibJava_WrapperJNI.new_BEID_ByteArray__SWIG_2(pucData, ulSize), true);
  }

	 /**
	  * Append data to the byte array
	  *
	  * @param pucData is the byte array
	  * @param ulSize is the size of the array
	  */
  public void Append(byte[] pucData, long ulSize) {
    beidlibJava_WrapperJNI.BEID_ByteArray_Append__SWIG_0(swigCPtr, this, pucData, ulSize);
  }

	 /**
	  * Append data to the byte array
	  */
  public void Append(BEID_ByteArray data) {
    beidlibJava_WrapperJNI.BEID_ByteArray_Append__SWIG_1(swigCPtr, this, BEID_ByteArray.getCPtr(data), data);
  }

	 /**
	  * clear the contents of the byte array
	  */
  public void Clear() {
    beidlibJava_WrapperJNI.BEID_ByteArray_Clear(swigCPtr, this);
  }

	 /**
	  * Return true if the content of the byte array is equal to the content of the byte array passed
	  */
  public boolean Equals(BEID_ByteArray data) {
    return beidlibJava_WrapperJNI.BEID_ByteArray_Equals(swigCPtr, this, BEID_ByteArray.getCPtr(data), data);
  }

	/** Return the number of bytes in the byte array */
	public long Size() {
    return beidlibJava_WrapperJNI.BEID_ByteArray_Size(swigCPtr, this);
  }

 	/**
	  * Return the content of the bytae array as an array of bytes
	  * If Size() == 0, then NULL is returned
	  */
  public byte[] GetBytes() {
	return beidlibJava_WrapperJNI.BEID_ByteArray_GetBytes(swigCPtr, this);
	}

	/**
	  * Write the binary content to a file
	  */
  public boolean writeToFile(String csFilePath) {
    return beidlibJava_WrapperJNI.BEID_ByteArray_writeToFile(swigCPtr, this, csFilePath);
  }

	/** Copy the content of a given byte array */
	public BEID_ByteArray assign(BEID_ByteArray bytearray) {
    return new BEID_ByteArray(beidlibJava_WrapperJNI.BEID_ByteArray_assign(swigCPtr, this, BEID_ByteArray.getCPtr(bytearray), bytearray), false);
  }

}
