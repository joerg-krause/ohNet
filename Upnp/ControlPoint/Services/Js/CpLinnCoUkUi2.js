 

/**
* Service Proxy for linn.co.uk:Ui:2
* @module Zapp
* @title Ui
*/

var ServiceUi = function(udn){	

	this.url = window.location.protocol + "//" + window.location.host + "/" + udn + "/linn.co.uk-Ui-2/control";  // upnp control url
	this.domain = "linn.co.uk";
	if (this.domain == "upnp.org") {
		this.domain = "schemas.upnp.org";
    }
	this.domain = this.domain.replace(/\./,"-");
	this.type = "Ui";
	this.version = "2";
	this.serviceName = "linn.co.uk-Ui-2";
	this.subscriptionId = "";  // Subscription identifier unique to each Subscription Manager 
	this.udn = udn;   // device name
	
	// Collection of service properties
	this.serviceProperties = {};
	this.serviceProperties["TestPattern"] = new Zapp.ServiceProperty("TestPattern");
	this.serviceProperties["TestModeEnabled"] = new Zapp.ServiceProperty("TestModeEnabled");
	this.serviceProperties["LightLevel"] = new Zapp.ServiceProperty("LightLevel");
	this.serviceProperties["DisplayBrightness"] = new Zapp.ServiceProperty("DisplayBrightness");
	this.serviceProperties["DisplayBrightnessAuto"] = new Zapp.ServiceProperty("DisplayBrightnessAuto");
	this.serviceProperties["InfraredCommands"] = new Zapp.ServiceProperty("InfraredCommands");
	this.serviceProperties["InfraredTerminalCommands"] = new Zapp.ServiceProperty("InfraredTerminalCommands");
	this.serviceProperties["DisplayUpsideDown"] = new Zapp.ServiceProperty("DisplayUpsideDown");
	this.serviceProperties["DisplayScrollText"] = new Zapp.ServiceProperty("DisplayScrollText");
	this.serviceProperties["DisplaySleep"] = new Zapp.ServiceProperty("DisplaySleep");
	this.serviceProperties["DisplayLedOff"] = new Zapp.ServiceProperty("DisplayLedOff");
	this.serviceProperties["TerminalInputCode"] = new Zapp.ServiceProperty("TerminalInputCode");
	this.serviceProperties["TerminalInputName"] = new Zapp.ServiceProperty("TerminalInputName");
	this.serviceProperties["DisplayPixels"] = new Zapp.ServiceProperty("DisplayPixels");
}

ServiceUi.kInfraredCommandsNone = "None";
ServiceUi.kInfraredCommandsAll = "All";
ServiceUi.kInfraredCommandsCd = "Cd";
ServiceUi.kInfraredCommandsDvd = "Dvd";
ServiceUi.kInfraredTerminalCommandsNone = "None";
ServiceUi.kInfraredTerminalCommandsAll = "All";
ServiceUi.kInfraredTerminalCommandsCd = "Cd";
ServiceUi.kInfraredTerminalCommandsDvd = "Dvd";


/**
* Subscribes the service to the subscription manager to listen for property change events
* @method Subscribed
* @param {Function} serviceAddedFunction The function that executes once the subscription is successful
*/
ServiceUi.prototype.subscribe = function (serviceAddedFunction) {
    Zapp.SubscriptionManager.addService(this,serviceAddedFunction);
}


/**
* Unsubscribes the service from the subscription manager to stop listening for property change events
* @method Subscribed
* @param {Function} serviceAddedFunction The function that executes once the subscription is successful
*/
ServiceUi.prototype.unsubscribe = function () {
    Zapp.SubscriptionManager.removeService(this.subscriptionId);
}




/**
* Adds a listener to handle "TestPattern" property change events
* @method TestPattern_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.TestPattern_Changed = function (stateChangedFunction) {
    this.serviceProperties.TestPattern.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readIntParameter(state)); 
	});
}


/**
* Adds a listener to handle "TestModeEnabled" property change events
* @method TestModeEnabled_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.TestModeEnabled_Changed = function (stateChangedFunction) {
    this.serviceProperties.TestModeEnabled.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "LightLevel" property change events
* @method LightLevel_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.LightLevel_Changed = function (stateChangedFunction) {
    this.serviceProperties.LightLevel.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readIntParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayBrightness" property change events
* @method DisplayBrightness_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayBrightness_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayBrightness.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readIntParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayBrightnessAuto" property change events
* @method DisplayBrightnessAuto_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayBrightnessAuto_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayBrightnessAuto.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "InfraredCommands" property change events
* @method InfraredCommands_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.InfraredCommands_Changed = function (stateChangedFunction) {
    this.serviceProperties.InfraredCommands.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readStringParameter(state)); 
	});
}


/**
* Adds a listener to handle "InfraredTerminalCommands" property change events
* @method InfraredTerminalCommands_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.InfraredTerminalCommands_Changed = function (stateChangedFunction) {
    this.serviceProperties.InfraredTerminalCommands.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readStringParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayUpsideDown" property change events
* @method DisplayUpsideDown_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayUpsideDown_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayUpsideDown.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayScrollText" property change events
* @method DisplayScrollText_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayScrollText_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayScrollText.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplaySleep" property change events
* @method DisplaySleep_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplaySleep_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplaySleep.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayLedOff" property change events
* @method DisplayLedOff_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayLedOff_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayLedOff.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBoolParameter(state)); 
	});
}


/**
* Adds a listener to handle "TerminalInputCode" property change events
* @method TerminalInputCode_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.TerminalInputCode_Changed = function (stateChangedFunction) {
    this.serviceProperties.TerminalInputCode.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readIntParameter(state)); 
	});
}


/**
* Adds a listener to handle "TerminalInputName" property change events
* @method TerminalInputName_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.TerminalInputName_Changed = function (stateChangedFunction) {
    this.serviceProperties.TerminalInputName.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readStringParameter(state)); 
	});
}


/**
* Adds a listener to handle "DisplayPixels" property change events
* @method DisplayPixels_Changed
* @param {Function} stateChangedFunction The handler for state changes
*/
ServiceUi.prototype.DisplayPixels_Changed = function (stateChangedFunction) {
    this.serviceProperties.DisplayPixels.addListener(function (state) 
	{ 
		stateChangedFunction(Zapp.SoapRequest.readBinaryParameter(state)); 
	});
}


/**
* A service action to DisplayTestPattern
* @method DisplayTestPattern
* @param {Int} aTestPattern An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayTestPattern = function(aTestPattern, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayTestPattern", this.url, this.domain, this.type, this.version);		
    request.writeIntParameter("aTestPattern", aTestPattern);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayFill
* @method DisplayFill
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayFill = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayFill", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayClear
* @method DisplayClear
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayClear = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayClear", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetTestModeEnabled
* @method SetTestModeEnabled
* @param {Boolean} aEnabled An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetTestModeEnabled = function(aEnabled, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetTestModeEnabled", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aEnabled", aEnabled);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SimulateInfraredInput
* @method SimulateInfraredInput
* @param {Int} aCode An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SimulateInfraredInput = function(aCode, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SimulateInfraredInput", this.url, this.domain, this.type, this.version);		
    request.writeIntParameter("aCode", aCode);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SimulateButtonInput
* @method SimulateButtonInput
* @param {Int} aCode An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SimulateButtonInput = function(aCode, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SimulateButtonInput", this.url, this.domain, this.type, this.version);		
    request.writeIntParameter("aCode", aCode);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SimulateLightSensor
* @method SimulateLightSensor
* @param {Int} aLightLevel An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SimulateLightSensor = function(aLightLevel, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SimulateLightSensor", this.url, this.domain, this.type, this.version);		
    request.writeIntParameter("aLightLevel", aLightLevel);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to GetLightSensorData
* @method GetLightSensorData
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.GetLightSensorData = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("GetLightSensorData", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aLightLevel"] = Zapp.SoapRequest.readIntParameter(result["aLightLevel"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplayBrightness
* @method SetDisplayBrightness
* @param {Int} aBrightness An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplayBrightness = function(aBrightness, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplayBrightness", this.url, this.domain, this.type, this.version);		
    request.writeIntParameter("aBrightness", aBrightness);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplayBrightnessAuto
* @method SetDisplayBrightnessAuto
* @param {Boolean} aBrightnessAuto An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplayBrightnessAuto = function(aBrightnessAuto, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplayBrightnessAuto", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aBrightnessAuto", aBrightnessAuto);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetInfraredCommands
* @method SetInfraredCommands
* @param {String} aCommands An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetInfraredCommands = function(aCommands, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetInfraredCommands", this.url, this.domain, this.type, this.version);		
    request.writeStringParameter("aCommands", aCommands);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to InfraredCommands
* @method InfraredCommands
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.InfraredCommands = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("InfraredCommands", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aCommands"] = Zapp.SoapRequest.readStringParameter(result["aCommands"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetInfraredTerminalCommands
* @method SetInfraredTerminalCommands
* @param {String} aCommands An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetInfraredTerminalCommands = function(aCommands, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetInfraredTerminalCommands", this.url, this.domain, this.type, this.version);		
    request.writeStringParameter("aCommands", aCommands);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to InfraredTerminalCommands
* @method InfraredTerminalCommands
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.InfraredTerminalCommands = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("InfraredTerminalCommands", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aCommands"] = Zapp.SoapRequest.readStringParameter(result["aCommands"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayBrightness
* @method DisplayBrightness
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayBrightness = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayBrightness", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aBrightness"] = Zapp.SoapRequest.readIntParameter(result["aBrightness"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayBrightnessAuto
* @method DisplayBrightnessAuto
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayBrightnessAuto = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayBrightnessAuto", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aBrightnessAuto"] = Zapp.SoapRequest.readBoolParameter(result["aBrightnessAuto"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayUpsideDown
* @method DisplayUpsideDown
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayUpsideDown = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayUpsideDown", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aUpsideDown"] = Zapp.SoapRequest.readBoolParameter(result["aUpsideDown"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplayUpsideDown
* @method SetDisplayUpsideDown
* @param {Boolean} aUpsideDown An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplayUpsideDown = function(aUpsideDown, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplayUpsideDown", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aUpsideDown", aUpsideDown);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplayScrollText
* @method SetDisplayScrollText
* @param {Boolean} aDisplayScrollText An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplayScrollText = function(aDisplayScrollText, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplayScrollText", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aDisplayScrollText", aDisplayScrollText);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayScrollText
* @method DisplayScrollText
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayScrollText = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayScrollText", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aDisplayScrollTextEnabled"] = Zapp.SoapRequest.readBoolParameter(result["aDisplayScrollTextEnabled"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplaySleep
* @method SetDisplaySleep
* @param {Boolean} aEnabled An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplaySleep = function(aEnabled, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplaySleep", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aEnabled", aEnabled);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplaySleep
* @method DisplaySleep
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplaySleep = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplaySleep", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aEnabled"] = Zapp.SoapRequest.readBoolParameter(result["aEnabled"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to SetDisplayLedOff
* @method SetDisplayLedOff
* @param {Boolean} aOff An action parameter
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.SetDisplayLedOff = function(aOff, successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("SetDisplayLedOff", this.url, this.domain, this.type, this.version);		
    request.writeBoolParameter("aOff", aOff);
    request.send(function(result){
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}


/**
* A service action to DisplayLedOff
* @method DisplayLedOff
* @param {Function} successFunction The function that is executed when the action has completed successfully
* @param {Function} errorFunction The function that is executed when the action has cause an error
*/
ServiceUi.prototype.DisplayLedOff = function(successFunction, errorFunction){	
	var request = new Zapp.SoapRequest("DisplayLedOff", this.url, this.domain, this.type, this.version);		
    request.send(function(result){
		result["aOff"] = Zapp.SoapRequest.readBoolParameter(result["aOff"]);	
	
		if (successFunction){
			successFunction(result);
		}
	}, function(message, transport) {
		if (errorFunction) {errorFunction(message, transport);}
	});
}



