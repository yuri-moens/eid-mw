/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.35
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package be.belgium.eid;

/******************************************************************************//**
  * Class for the picture document on a EID Card
  * \see BEID_EIDCard.getPicture()	BEID_EIDCard.getDocument()
  *********************************************************************************/
public class BEID_Picture extends BEID_Biometric {
  private long swigCPtr;

  protected BEID_Picture(long cPtr, boolean cMemoryOwn) {
    super(beidlibJava_WrapperJNI.SWIGBEID_PictureUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BEID_Picture obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      beidlibJava_WrapperJNI.delete_BEID_Picture(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

	/** Get the picture itself (jpg format) */
  public BEID_ByteArray getData() throws java.lang.Exception {
    return new BEID_ByteArray(beidlibJava_WrapperJNI.BEID_Picture_getData(swigCPtr, this), false);
  }

	/** Get the hash of the picture */
  public BEID_ByteArray getHash() throws java.lang.Exception {
    return new BEID_ByteArray(beidlibJava_WrapperJNI.BEID_Picture_getHash(swigCPtr, this), false);
  }

}