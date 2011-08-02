#include <jni.h>
#include <malloc.h>
#include <stdlib.h>
#include "Property.h"
#include "PropertyCallback.h"
#include "JniCallbackList.h"
#include "OpenHome/Net/C/Ohnet.h"
#include "OpenHome/Net/C/Service.h"

#ifdef __cplusplus
extern "C" {
#endif

JniCallbackList *iList = NULL;

void STDCALL ChangeCallback(void* aPtr)
{

	JniObjRef* ref = (JniObjRef*) aPtr;
	JNIEnv *env;
	jclass cls;
	jmethodID mid;
	jint ret;
	
	ret = (*(ref->vm))->AttachCurrentThread(ref->vm, (void **) &env, NULL);
	if (ret < 0)
	{
		printf("PropertyJNI: Unable to attach thread to JVM.\n");
		fflush(stdout);
		return;
	}
	cls = (*env)->GetObjectClass(env, ref->callbackObj);
	mid = (*env)->GetMethodID(env, cls, "notifyChange", "()V");
	if (mid == 0) {
		printf("PropertyJNI: Method ID notifyChange() not found.\n");
		return;
	}
	(*env)->CallVoidMethod(env, ref->callbackObj, mid);
	
	(*(ref->vm))->DetachCurrentThread(ref->vm);
}

void STDCALL InitialiseReferences(JNIEnv *aEnv, jobject aObject, JniObjRef **aRef)
{
	jint ret;

	*aRef = (JniObjRef*) malloc(sizeof(JniObjRef));
	if (!iList)
	{
		iList = JniCallbackListCreate();
	}

	ret = (*aEnv)->GetJavaVM(aEnv, &(*aRef)->vm);
	if (ret < 0) {
		printf("PropertyJNI: Unable to get reference to the current Java VM.\n");
		fflush(stdout);
	}
	(*aRef)->callbackObj = (*aEnv)->NewWeakGlobalRef(aEnv, aObject);
	if ((*aRef)->callbackObj == NULL) {
		printf("PropertyJNI: Callback object not stored.\n");
		fflush(stdout);
	}
	JniCallbackListAddElement(&iList, *aRef);
}

/*
 * Class:     org_openhome_net_core_Property
 * Method:    ServicePropertyDestroy
 * Signature: (J)V
 */
JNIEXPORT void JNICALL Java_org_openhome_net_core_Property_ServicePropertyDestroy
  (JNIEnv *aEnv, jclass aClass, jlong aProperty)
{
	ServiceProperty property = (ServiceProperty) (size_t)aProperty;
	aClass = aClass;
	
	JniCallbackListDestroy(aEnv, &iList);
	iList = NULL;
	ServicePropertyDestroy(property);
}

#ifdef __cplusplus
}
#endif
