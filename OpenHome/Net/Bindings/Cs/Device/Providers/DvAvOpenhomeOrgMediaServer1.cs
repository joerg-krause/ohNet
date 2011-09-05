using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using OpenHome.Net.Core;

namespace OpenHome.Net.Device.Providers
{
    public interface IDvProviderAvOpenhomeOrgMediaServer1 : IDisposable
    {

        /// <summary>
        /// Set the value of the ManufacturerName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyManufacturerName(string aValue);

        /// <summary>
        /// Get a copy of the value of the ManufacturerName property
        /// </summary>
        /// <returns>Value of the ManufacturerName property.</param>
        string PropertyManufacturerName();

        /// <summary>
        /// Set the value of the ManufacturerInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyManufacturerInfo(string aValue);

        /// <summary>
        /// Get a copy of the value of the ManufacturerInfo property
        /// </summary>
        /// <returns>Value of the ManufacturerInfo property.</param>
        string PropertyManufacturerInfo();

        /// <summary>
        /// Set the value of the ManufacturerUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyManufacturerUrl(string aValue);

        /// <summary>
        /// Get a copy of the value of the ManufacturerUrl property
        /// </summary>
        /// <returns>Value of the ManufacturerUrl property.</param>
        string PropertyManufacturerUrl();

        /// <summary>
        /// Set the value of the ManufacturerImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyManufacturerImageUri(string aValue);

        /// <summary>
        /// Get a copy of the value of the ManufacturerImageUri property
        /// </summary>
        /// <returns>Value of the ManufacturerImageUri property.</param>
        string PropertyManufacturerImageUri();

        /// <summary>
        /// Set the value of the ModelName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyModelName(string aValue);

        /// <summary>
        /// Get a copy of the value of the ModelName property
        /// </summary>
        /// <returns>Value of the ModelName property.</param>
        string PropertyModelName();

        /// <summary>
        /// Set the value of the ModelInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyModelInfo(string aValue);

        /// <summary>
        /// Get a copy of the value of the ModelInfo property
        /// </summary>
        /// <returns>Value of the ModelInfo property.</param>
        string PropertyModelInfo();

        /// <summary>
        /// Set the value of the ModelUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyModelUrl(string aValue);

        /// <summary>
        /// Get a copy of the value of the ModelUrl property
        /// </summary>
        /// <returns>Value of the ModelUrl property.</param>
        string PropertyModelUrl();

        /// <summary>
        /// Set the value of the ModelImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyModelImageUri(string aValue);

        /// <summary>
        /// Get a copy of the value of the ModelImageUri property
        /// </summary>
        /// <returns>Value of the ModelImageUri property.</param>
        string PropertyModelImageUri();

        /// <summary>
        /// Set the value of the ProductName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyProductName(string aValue);

        /// <summary>
        /// Get a copy of the value of the ProductName property
        /// </summary>
        /// <returns>Value of the ProductName property.</param>
        string PropertyProductName();

        /// <summary>
        /// Set the value of the ProductInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyProductInfo(string aValue);

        /// <summary>
        /// Get a copy of the value of the ProductInfo property
        /// </summary>
        /// <returns>Value of the ProductInfo property.</param>
        string PropertyProductInfo();

        /// <summary>
        /// Set the value of the ProductUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyProductUrl(string aValue);

        /// <summary>
        /// Get a copy of the value of the ProductUrl property
        /// </summary>
        /// <returns>Value of the ProductUrl property.</param>
        string PropertyProductUrl();

        /// <summary>
        /// Set the value of the ProductImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyProductImageUri(string aValue);

        /// <summary>
        /// Get a copy of the value of the ProductImageUri property
        /// </summary>
        /// <returns>Value of the ProductImageUri property.</param>
        string PropertyProductImageUri();

        /// <summary>
        /// Set the value of the Attributes property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        bool SetPropertyAttributes(string aValue);

        /// <summary>
        /// Get a copy of the value of the Attributes property
        /// </summary>
        /// <returns>Value of the Attributes property.</param>
        string PropertyAttributes();
        
    }
    /// <summary>
    /// Provider for the av.openhome.org:MediaServer:1 UPnP service
    /// </summary>
    public class DvProviderAvOpenhomeOrgMediaServer1 : DvProvider, IDisposable, IDvProviderAvOpenhomeOrgMediaServer1
    {
        private GCHandle iGch;
        private ActionDelegate iDelegateManufacturer;
        private ActionDelegate iDelegateModel;
        private ActionDelegate iDelegateProduct;
        private ActionDelegate iDelegateAttributes;
        private ActionDelegate iDelegateQuery;
        private PropertyString iPropertyManufacturerName;
        private PropertyString iPropertyManufacturerInfo;
        private PropertyString iPropertyManufacturerUrl;
        private PropertyString iPropertyManufacturerImageUri;
        private PropertyString iPropertyModelName;
        private PropertyString iPropertyModelInfo;
        private PropertyString iPropertyModelUrl;
        private PropertyString iPropertyModelImageUri;
        private PropertyString iPropertyProductName;
        private PropertyString iPropertyProductInfo;
        private PropertyString iPropertyProductUrl;
        private PropertyString iPropertyProductImageUri;
        private PropertyString iPropertyAttributes;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aDevice">Device which owns this provider</param>
        protected DvProviderAvOpenhomeOrgMediaServer1(DvDevice aDevice)
            : base(aDevice, "av.openhome.org", "MediaServer", 1)
        {
            iGch = GCHandle.Alloc(this);
            List<String> allowedValues = new List<String>();
            iPropertyManufacturerName = new PropertyString(new ParameterString("ManufacturerName", allowedValues));
            AddProperty(iPropertyManufacturerName);
            iPropertyManufacturerInfo = new PropertyString(new ParameterString("ManufacturerInfo", allowedValues));
            AddProperty(iPropertyManufacturerInfo);
            iPropertyManufacturerUrl = new PropertyString(new ParameterString("ManufacturerUrl", allowedValues));
            AddProperty(iPropertyManufacturerUrl);
            iPropertyManufacturerImageUri = new PropertyString(new ParameterString("ManufacturerImageUri", allowedValues));
            AddProperty(iPropertyManufacturerImageUri);
            iPropertyModelName = new PropertyString(new ParameterString("ModelName", allowedValues));
            AddProperty(iPropertyModelName);
            iPropertyModelInfo = new PropertyString(new ParameterString("ModelInfo", allowedValues));
            AddProperty(iPropertyModelInfo);
            iPropertyModelUrl = new PropertyString(new ParameterString("ModelUrl", allowedValues));
            AddProperty(iPropertyModelUrl);
            iPropertyModelImageUri = new PropertyString(new ParameterString("ModelImageUri", allowedValues));
            AddProperty(iPropertyModelImageUri);
            iPropertyProductName = new PropertyString(new ParameterString("ProductName", allowedValues));
            AddProperty(iPropertyProductName);
            iPropertyProductInfo = new PropertyString(new ParameterString("ProductInfo", allowedValues));
            AddProperty(iPropertyProductInfo);
            iPropertyProductUrl = new PropertyString(new ParameterString("ProductUrl", allowedValues));
            AddProperty(iPropertyProductUrl);
            iPropertyProductImageUri = new PropertyString(new ParameterString("ProductImageUri", allowedValues));
            AddProperty(iPropertyProductImageUri);
            iPropertyAttributes = new PropertyString(new ParameterString("Attributes", allowedValues));
            AddProperty(iPropertyAttributes);
        }

        /// <summary>
        /// Set the value of the ManufacturerName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyManufacturerName(string aValue)
        {
            return SetPropertyString(iPropertyManufacturerName, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ManufacturerName property
        /// </summary>
        /// <returns>Value of the ManufacturerName property.</returns>
        public string PropertyManufacturerName()
        {
            return iPropertyManufacturerName.Value();
        }

        /// <summary>
        /// Set the value of the ManufacturerInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyManufacturerInfo(string aValue)
        {
            return SetPropertyString(iPropertyManufacturerInfo, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ManufacturerInfo property
        /// </summary>
        /// <returns>Value of the ManufacturerInfo property.</returns>
        public string PropertyManufacturerInfo()
        {
            return iPropertyManufacturerInfo.Value();
        }

        /// <summary>
        /// Set the value of the ManufacturerUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyManufacturerUrl(string aValue)
        {
            return SetPropertyString(iPropertyManufacturerUrl, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ManufacturerUrl property
        /// </summary>
        /// <returns>Value of the ManufacturerUrl property.</returns>
        public string PropertyManufacturerUrl()
        {
            return iPropertyManufacturerUrl.Value();
        }

        /// <summary>
        /// Set the value of the ManufacturerImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyManufacturerImageUri(string aValue)
        {
            return SetPropertyString(iPropertyManufacturerImageUri, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ManufacturerImageUri property
        /// </summary>
        /// <returns>Value of the ManufacturerImageUri property.</returns>
        public string PropertyManufacturerImageUri()
        {
            return iPropertyManufacturerImageUri.Value();
        }

        /// <summary>
        /// Set the value of the ModelName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyModelName(string aValue)
        {
            return SetPropertyString(iPropertyModelName, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ModelName property
        /// </summary>
        /// <returns>Value of the ModelName property.</returns>
        public string PropertyModelName()
        {
            return iPropertyModelName.Value();
        }

        /// <summary>
        /// Set the value of the ModelInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyModelInfo(string aValue)
        {
            return SetPropertyString(iPropertyModelInfo, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ModelInfo property
        /// </summary>
        /// <returns>Value of the ModelInfo property.</returns>
        public string PropertyModelInfo()
        {
            return iPropertyModelInfo.Value();
        }

        /// <summary>
        /// Set the value of the ModelUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyModelUrl(string aValue)
        {
            return SetPropertyString(iPropertyModelUrl, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ModelUrl property
        /// </summary>
        /// <returns>Value of the ModelUrl property.</returns>
        public string PropertyModelUrl()
        {
            return iPropertyModelUrl.Value();
        }

        /// <summary>
        /// Set the value of the ModelImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyModelImageUri(string aValue)
        {
            return SetPropertyString(iPropertyModelImageUri, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ModelImageUri property
        /// </summary>
        /// <returns>Value of the ModelImageUri property.</returns>
        public string PropertyModelImageUri()
        {
            return iPropertyModelImageUri.Value();
        }

        /// <summary>
        /// Set the value of the ProductName property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyProductName(string aValue)
        {
            return SetPropertyString(iPropertyProductName, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ProductName property
        /// </summary>
        /// <returns>Value of the ProductName property.</returns>
        public string PropertyProductName()
        {
            return iPropertyProductName.Value();
        }

        /// <summary>
        /// Set the value of the ProductInfo property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyProductInfo(string aValue)
        {
            return SetPropertyString(iPropertyProductInfo, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ProductInfo property
        /// </summary>
        /// <returns>Value of the ProductInfo property.</returns>
        public string PropertyProductInfo()
        {
            return iPropertyProductInfo.Value();
        }

        /// <summary>
        /// Set the value of the ProductUrl property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyProductUrl(string aValue)
        {
            return SetPropertyString(iPropertyProductUrl, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ProductUrl property
        /// </summary>
        /// <returns>Value of the ProductUrl property.</returns>
        public string PropertyProductUrl()
        {
            return iPropertyProductUrl.Value();
        }

        /// <summary>
        /// Set the value of the ProductImageUri property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyProductImageUri(string aValue)
        {
            return SetPropertyString(iPropertyProductImageUri, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the ProductImageUri property
        /// </summary>
        /// <returns>Value of the ProductImageUri property.</returns>
        public string PropertyProductImageUri()
        {
            return iPropertyProductImageUri.Value();
        }

        /// <summary>
        /// Set the value of the Attributes property
        /// </summary>
        /// <param name="aValue">New value for the property</param>
        /// <returns>true if the value has been updated; false if aValue was the same as the previous value</returns>
        public bool SetPropertyAttributes(string aValue)
        {
            return SetPropertyString(iPropertyAttributes, aValue);
        }

        /// <summary>
        /// Get a copy of the value of the Attributes property
        /// </summary>
        /// <returns>Value of the Attributes property.</returns>
        public string PropertyAttributes()
        {
            return iPropertyAttributes.Value();
        }

        /// <summary>
        /// Signal that the action Manufacturer is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// Manufacturer must be overridden if this is called.</remarks>
        protected void EnableActionManufacturer()
        {
            OpenHome.Net.Core.Action action = new OpenHome.Net.Core.Action("Manufacturer");
            action.AddOutputParameter(new ParameterRelated("Name", iPropertyManufacturerName));
            action.AddOutputParameter(new ParameterRelated("Info", iPropertyManufacturerInfo));
            action.AddOutputParameter(new ParameterRelated("Url", iPropertyManufacturerUrl));
            action.AddOutputParameter(new ParameterRelated("ImageUri", iPropertyManufacturerImageUri));
            iDelegateManufacturer = new ActionDelegate(DoManufacturer);
            EnableAction(action, iDelegateManufacturer, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action Model is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// Model must be overridden if this is called.</remarks>
        protected void EnableActionModel()
        {
            OpenHome.Net.Core.Action action = new OpenHome.Net.Core.Action("Model");
            action.AddOutputParameter(new ParameterRelated("Name", iPropertyModelName));
            action.AddOutputParameter(new ParameterRelated("Info", iPropertyModelInfo));
            action.AddOutputParameter(new ParameterRelated("Url", iPropertyModelUrl));
            action.AddOutputParameter(new ParameterRelated("ImageUri", iPropertyModelImageUri));
            iDelegateModel = new ActionDelegate(DoModel);
            EnableAction(action, iDelegateModel, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action Product is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// Product must be overridden if this is called.</remarks>
        protected void EnableActionProduct()
        {
            OpenHome.Net.Core.Action action = new OpenHome.Net.Core.Action("Product");
            action.AddOutputParameter(new ParameterRelated("Name", iPropertyProductName));
            action.AddOutputParameter(new ParameterRelated("Info", iPropertyProductInfo));
            action.AddOutputParameter(new ParameterRelated("Url", iPropertyProductUrl));
            action.AddOutputParameter(new ParameterRelated("ImageUri", iPropertyProductImageUri));
            iDelegateProduct = new ActionDelegate(DoProduct);
            EnableAction(action, iDelegateProduct, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action Attributes is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// Attributes must be overridden if this is called.</remarks>
        protected void EnableActionAttributes()
        {
            OpenHome.Net.Core.Action action = new OpenHome.Net.Core.Action("Attributes");
            action.AddOutputParameter(new ParameterRelated("Value", iPropertyAttributes));
            iDelegateAttributes = new ActionDelegate(DoAttributes);
            EnableAction(action, iDelegateAttributes, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Signal that the action Query is supported.
        /// </summary>
        /// <remarks>The action's availability will be published in the device's service.xml.
        /// Query must be overridden if this is called.</remarks>
        protected void EnableActionQuery()
        {
            OpenHome.Net.Core.Action action = new OpenHome.Net.Core.Action("Query");
            List<String> allowedValues = new List<String>();
            action.AddInputParameter(new ParameterString("Request", allowedValues));
            action.AddOutputParameter(new ParameterString("Result", allowedValues));
            iDelegateQuery = new ActionDelegate(DoQuery);
            EnableAction(action, iDelegateQuery, GCHandle.ToIntPtr(iGch));
        }

        /// <summary>
        /// Manufacturer action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Manufacturer action for the owning device.
        ///
        /// Must be implemented iff EnableActionManufacturer was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aName"></param>
        /// <param name="aInfo"></param>
        /// <param name="aUrl"></param>
        /// <param name="aImageUri"></param>
        protected virtual void Manufacturer(uint aVersion, out string aName, out string aInfo, out string aUrl, out string aImageUri)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Model action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Model action for the owning device.
        ///
        /// Must be implemented iff EnableActionModel was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aName"></param>
        /// <param name="aInfo"></param>
        /// <param name="aUrl"></param>
        /// <param name="aImageUri"></param>
        protected virtual void Model(uint aVersion, out string aName, out string aInfo, out string aUrl, out string aImageUri)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Product action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Product action for the owning device.
        ///
        /// Must be implemented iff EnableActionProduct was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aName"></param>
        /// <param name="aInfo"></param>
        /// <param name="aUrl"></param>
        /// <param name="aImageUri"></param>
        protected virtual void Product(uint aVersion, out string aName, out string aInfo, out string aUrl, out string aImageUri)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Attributes action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Attributes action for the owning device.
        ///
        /// Must be implemented iff EnableActionAttributes was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aValue"></param>
        protected virtual void Attributes(uint aVersion, out string aValue)
        {
            throw (new ActionDisabledError());
        }

        /// <summary>
        /// Query action.
        /// </summary>
        /// <remarks>Will be called when the device stack receives an invocation of the
        /// Query action for the owning device.
        ///
        /// Must be implemented iff EnableActionQuery was called.</remarks>
        /// <param name="aVersion">Version of the service being requested (will be <= the version advertised)</param>
        /// <param name="aRequest"></param>
        /// <param name="aResult"></param>
        protected virtual void Query(uint aVersion, string aRequest, out string aResult)
        {
            throw (new ActionDisabledError());
        }

        private static int DoManufacturer(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderAvOpenhomeOrgMediaServer1 self = (DvProviderAvOpenhomeOrgMediaServer1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string name;
            string info;
            string url;
            string imageUri;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.Manufacturer(aVersion, out name, out info, out url, out imageUri);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("         Only ActionError or PropertyUpdateError can be thrown by actions");
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("Name", name);
                invocation.WriteString("Info", info);
                invocation.WriteString("Url", url);
                invocation.WriteString("ImageUri", imageUri);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("ERROR: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("       Only ActionError can be thrown by action response writer");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return 0;
        }

        private static int DoModel(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderAvOpenhomeOrgMediaServer1 self = (DvProviderAvOpenhomeOrgMediaServer1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string name;
            string info;
            string url;
            string imageUri;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.Model(aVersion, out name, out info, out url, out imageUri);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("         Only ActionError or PropertyUpdateError can be thrown by actions");
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("Name", name);
                invocation.WriteString("Info", info);
                invocation.WriteString("Url", url);
                invocation.WriteString("ImageUri", imageUri);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("ERROR: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("       Only ActionError can be thrown by action response writer");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return 0;
        }

        private static int DoProduct(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderAvOpenhomeOrgMediaServer1 self = (DvProviderAvOpenhomeOrgMediaServer1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string name;
            string info;
            string url;
            string imageUri;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.Product(aVersion, out name, out info, out url, out imageUri);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("         Only ActionError or PropertyUpdateError can be thrown by actions");
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("Name", name);
                invocation.WriteString("Info", info);
                invocation.WriteString("Url", url);
                invocation.WriteString("ImageUri", imageUri);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("ERROR: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("       Only ActionError can be thrown by action response writer");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return 0;
        }

        private static int DoAttributes(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderAvOpenhomeOrgMediaServer1 self = (DvProviderAvOpenhomeOrgMediaServer1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string value;
            try
            {
                invocation.ReadStart();
                invocation.ReadEnd();
                self.Attributes(aVersion, out value);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("         Only ActionError or PropertyUpdateError can be thrown by actions");
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("Value", value);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("ERROR: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("       Only ActionError can be thrown by action response writer");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return 0;
        }

        private static int DoQuery(IntPtr aPtr, IntPtr aInvocation, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderAvOpenhomeOrgMediaServer1 self = (DvProviderAvOpenhomeOrgMediaServer1)gch.Target;
            DvInvocation invocation = new DvInvocation(aInvocation);
            string request;
            string result;
            try
            {
                invocation.ReadStart();
                request = invocation.ReadString("Request");
                invocation.ReadEnd();
                self.Query(aVersion, request, out result);
            }
            catch (ActionError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (PropertyUpdateError)
            {
                invocation.ReportError(501, "Invalid XML");
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("WARNING: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("         Only ActionError or PropertyUpdateError can be thrown by actions");
                return -1;
            }
            try
            {
                invocation.WriteStart();
                invocation.WriteString("Result", result);
                invocation.WriteEnd();
            }
            catch (ActionError)
            {
                return -1;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("ERROR: unexpected exception {0}(\"{1}\") thrown by {2}", e.GetType(), e.Message, e.TargetSite.Name);
                Console.WriteLine("       Only ActionError can be thrown by action response writer");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return 0;
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public virtual void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderAvOpenhomeOrgMediaServer1()
        {
            DoDispose();
        }

        private void DoDispose()
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                {
                    return;
                }
                DisposeProvider();
                iHandle = IntPtr.Zero;
            }
            iGch.Free();
        }
    }
}

