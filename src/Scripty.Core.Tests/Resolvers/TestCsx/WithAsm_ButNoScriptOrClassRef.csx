﻿#r ".\..\..\..\packages\NUnit.3.9.0\lib\net45\nunit.framework.dll"

//Write using supplied ScriptContext
Output.WriteLine("namespace TestNamespace{class TestClass{public void TestMethod(){}}}");

//with the referenced assembly
var bag = new NUnit.Framework.Internal.PropertyBag();
Output.WriteLine($"// {bag}");