// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace iRduino.ArduinoTemplates
{
    using System.Collections.Generic;
    using System.Globalization;
    using ArduinoInterfaces;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class ArduinoSketchT4 : ArduinoSketchT4Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 5 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

	var numberTm1640S = 0;
    var tm1640UnitNumbers = new List<int>();
    for (var m = 0; m < configurationOptions.DisplayUnitConfigurations.Count; m++)
    {
        if (configurationOptions.DisplayUnitConfigurations[m].IsTM1640)
        {
            tm1640UnitNumbers.Add(m);
            numberTm1640S += 1;
        }
    }
	string temp = "";
	int numberTM1638 = configurationOptions.DisplayUnitConfigurations.Count - numberTm1640S;
	int messageLengthInt = 0;
	string serialSpeed = configurationOptions.SerialPortSpeed;
	switch (configurationOptions.DisplayUnitConfigurations.Count)
	{
		case 1:
			temp = "single (1)";
			messageLengthInt = 16;
			break;
		case 2:
			temp = "double (2)";
			messageLengthInt = 27;
			break;
		case 3:
			temp = "triple (3)";
			messageLengthInt = 38;
			break;
		case 4:
			temp = "quadruple (4)";
			messageLengthInt = 49;
			break;
		case 5:
			temp = "quintuple (5)";
			messageLengthInt = 60;
			break;
		case 6:
			temp = "sextuple (6)";
			messageLengthInt = 71;
			break;
	}
	string messageLength = (messageLengthInt + Constants.ExtraMessageLengthTM1640 * numberTm1640S).ToString(CultureInfo.InvariantCulture);
    string messageReadUnitCheck = "";
	var count = 0;
        for (var p = 0; p < configurationOptions.DisplayUnitConfigurations.Count; p++)
        {
            if (configurationOptions.DisplayUnitConfigurations[p].IsTM1640)
            {
                if (count != 0)
                {
                    messageReadUnitCheck += " || ";
                }
                messageReadUnitCheck += string.Format("u=={0}", p + 1);
                count++;
            }
        }
        if (count == 0)
        {
            messageReadUnitCheck += "false";
        }

            
            #line default
            #line hidden
            this.Write("/*\r\niRduino - Arduino Sketch\r\n Author: Mark Silverwood\r\n \r\n Using TM1638 library " +
                    "from Ricardo Batista <rjbatista at gmail dot com>\r\n \r\n This Arduino Sketch inter" +
                    "faces to the iRduino windows application.\r\n This Sketch was generated on: ");
            
            #line 74 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now.ToShortDateString()));
            
            #line default
            #line hidden
            this.Write("\r\n This Sketch is for a ");
            
            #line 75 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(temp));
            
            #line default
            #line hidden
            this.Write(" Display Unit Configuration\r\n \r\n */\r\n\r\n");
            
            #line 79 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

 bool normal = false;
            bool inverted = false;
            foreach (var unit in configurationOptions.DisplayUnitConfigurations)
            {
                if (unit.Inverted)
                {
                    inverted = true;
                }
                else
                {
                    normal = true;
                }
            }
            if (numberTM1638 > 0)
            {
                if (normal)
                {

            
            #line default
            #line hidden
            this.Write("#include <TM1638.h>\r\n");
            
            #line 99 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

                }
                if (inverted)
                {

            
            #line default
            #line hidden
            this.Write("#include <InvertedTM1638.h>\r\n");
            
            #line 105 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

                }
            }
            if (numberTm1640S > 0)
            {

            
            #line default
            #line hidden
            this.Write("#include <TM1640.h>\r\n");
            
            #line 112 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

            }
 
            
            #line default
            #line hidden
            this.Write("\r\n//////Setup Here\r\n");
            
            #line 117 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
 if (numberTM1638 > 0)
 { 
            
            #line default
            #line hidden
            this.Write("#define dataPin ");
            
            #line 119 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pins.DataPin));
            
            #line default
            #line hidden
            this.Write("\r\n#define clockPin ");
            
            #line 120 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pins.ClockPin));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 121 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
 }  
            
            #line default
            #line hidden
            
            #line 122 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

	int tmCount = 0;
    for (var p = 0; p < configurationOptions.DisplayUnitConfigurations.Count; p++)
    {
        if (!configurationOptions.DisplayUnitConfigurations[p].IsTM1640)
        {

            
            #line default
            #line hidden
            this.Write("#define strobePin");
            
            #line 129 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 129 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pins.UnitStrobePins[p]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 130 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("#define TM1640dataPin");
            
            #line 135 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 135 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pins.TM1640DataPins[tmCount]));
            
            #line default
            #line hidden
            this.Write("\r\n#define TM1640clockPin");
            
            #line 136 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 136 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(pins.TM1640ClockPins[tmCount]));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 137 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

            tmCount++;
        }
    }

            
            #line default
            #line hidden
            this.Write("#define NumberUnit ");
            
            #line 142 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(configurationOptions.DisplayUnitConfigurations.Count));
            
            #line default
            #line hidden
            this.Write("\r\n#define NumberTM1638Units ");
            
            #line 143 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(configurationOptions.DisplayUnitConfigurations.Count - numberTm1640S));
            
            #line default
            #line hidden
            this.Write("\r\n//////Setup Finished\r\n\r\n#define startByte1 ");
            
            #line 146 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Constants.MessageStartByte1));
            
            #line default
            #line hidden
            this.Write("\r\n#define endByte ");
            
            #line 147 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Constants.MessageEndByte));
            
            #line default
            #line hidden
            this.Write("\r\n#define messageLength ");
            
            #line 148 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(messageLength));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 150 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

for (var p = 0; p < configurationOptions.DisplayUnitConfigurations.Count; p++)
{
    if (configurationOptions.DisplayUnitConfigurations[p].IsTM1640)
    {

            
            #line default
            #line hidden
            this.Write("TM1640 module");
            
            #line 156 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write("(TM1640dataPin");
            
            #line 156 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(",TM1640clockPin");
            
            #line 156 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(",false,0);\r\n");
            
            #line 157 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

    }
    else
    {
        if (!configurationOptions.DisplayUnitConfigurations[p].Inverted)
        {

            
            #line default
            #line hidden
            this.Write("TM1638 module");
            
            #line 164 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write("(dataPin,clockPin,strobePin");
            
            #line 164 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(",false,0);\r\n");
            
            #line 165 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("InvertedTM1638 module");
            
            #line 170 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write("(dataPin,clockPin,strobePin");
            
            #line 170 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(",false,0);\r\n");
            
            #line 171 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

        }
    }
}

            
            #line default
            #line hidden
            this.Write(@"
//// Variable Declarations
word leds; 
byte segments[8], TM1640segments[16], redLeds, greenLeds, intensity, unit, sum, i, readCount, checkerPosition;
byte buttons[NumberTM1638Units], oldbuttons[NumberTM1638Units], lastButtonSend[NumberTM1638Units];
long lastCheck, debounceDelay = 100;
boolean sendButtons = false;
byte messageHolder[messageLength], message[messageLength-4], messagePosition = -1;

void setup() {
	Serial.begin(");
            
            #line 186 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serialSpeed));
            
            #line default
            #line hidden
            this.Write(@");
	for(int u = 0; u < NumberTM1638Units; u++)
	{
		oldbuttons[u] = 0;
	}
	intensity = 0;
	lastCheck = millis();
}

void loop() {
	buttonsCheck();
	if (Serial.available() > 0){
		messagePosition++;
		if(messagePosition == messageLength) messagePosition = 0;
		messageHolder[messagePosition] = Serial.read();
		messageChecker();
	}
}

void messageChecker()
{
	checkerPosition = (messagePosition == 0) ? messageLength-1 : messagePosition - 1;
	if(messageHolder[checkerPosition] != endByte) return; //end byte
	checkerPosition = (messagePosition == messageLength -1) ? 0 : messagePosition + 1;
	if(messageHolder[checkerPosition]!= startByte1) return; //start byte1
	checkerPosition = (checkerPosition == messageLength - 1) ? 0 : checkerPosition+1;
	if(messageHolder[checkerPosition]!= startByte2) return; // start byte 2
	checkerPosition++;
	readCount = 0;
	sum = 0;
	while (readCount < messageLength-4)
	{
		if(checkerPosition == messageLength) checkerPosition = 0;
		message[readCount] = messageHolder[checkerPosition];
		sum += messageHolder[checkerPosition];
		readCount++;
		checkerPosition++;
	}
	if(sum == messageHolder[messagePosition]) messageRead(message);
}

void messageRead(byte _message[]){
	i = 0;
	intensity = _message[i++];
	for(int u = 1; u <= NumberUnits; u++)
	{
		unit = _message[i++];
		if(");
            
            #line 233 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(messageReadUnitCheck));
            
            #line default
            #line hidden
            this.Write(@")
		{
			for(int x = 0;x<16;x++){
				TM1640segments[x] = _message[i++];
			}
			updateDisplay(unit,word(0,0),TM1640segments,intensity);
		}
		else
		{
			greenLeds = _message[i++];
			redLeds = _message[i++];
			for(int x = 0;x<8;x++){
				segments[x] = _message[i++];
			}
			updateDisplay(unit,word(greenLeds,redLeds),segments,intensity);
		}
	}
}

void buttonsCheck(){
	if ((millis() - lastCheck)<debounceDelay) return;
	lastCheck = millis();
");
            
            #line 255 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

	int buttonCount = 0;
	for (var p = 0; p < configurationOptions.DisplayUnitConfigurations.Count; p++)
	{
		if (!configurationOptions.DisplayUnitConfigurations[p].IsTM1640)
		{

            
            #line default
            #line hidden
            this.Write("\tbuttons[");
            
            #line 262 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(buttonCount));
            
            #line default
            #line hidden
            this.Write("] = module");
            
            #line 262 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".getButtons();\r\n");
            
            #line 263 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

			buttonCount++;
		}
	}

            
            #line default
            #line hidden
            this.Write(@"	sendButtons = false;
	for(int u = 0; u < NumberTM1638Units; u++)
	{
		if (buttons[u] != lastButtonSend[u] && buttons[u] != oldbuttons[u]){
			sendButtons = true;
		}
		oldbuttons[u] = buttons[u];
	}
	if(sendButtons){
		Serial.write(startByte1);
		for(int u = 0; u < NumberTM1638Units; u++)
		{
			lastButtonSend[u] = buttons[u];
			Serial.write(lastButtonSend[u]);
		}
	}
}

void updateDisplay(byte unit, word _leds, byte _segments[], byte _intensity){
	switch(unit){
");
            
            #line 288 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

	for (var p = 0; p < configurationOptions.DisplayUnitConfigurations.Count; p++)
	{
		if (configurationOptions.DisplayUnitConfigurations[p].IsTM1640)
		{

            
            #line default
            #line hidden
            this.Write("\t\tcase ");
            
            #line 294 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(":\r\n\t\tmodule");
            
            #line 295 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".setupDisplay(true,_intensity);\r\n\t\tmodule");
            
            #line 296 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".setDisplay(_segments,16);\r\n\t\tbreak;\r\n");
            
            #line 298 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

		}
		else
		{

            
            #line default
            #line hidden
            this.Write("\t\tcase ");
            
            #line 303 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(":\r\n\t\tmodule");
            
            #line 304 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".setupDisplay(true,_intensity);\r\n\t\tmodule");
            
            #line 305 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".setLEDs(_leds);\r\n\t\tmodule");
            
            #line 306 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p + 1));
            
            #line default
            #line hidden
            this.Write(".setDisplay(_segments);\r\n\t\tbreak;\r\n");
            
            #line 308 "C:\Users\a0017753\Documents\GitHub\iRduino\iRduino\ArduinoTemplates\ArduinoSketchT4.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("  }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class ArduinoSketchT4Base
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
